using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork.Builder.UserControls;
using Zork.Builder.ViewModels;
using Zork.Builder.Views;

namespace Zork.Builder
{
    public partial class ZorkBuilder : Form
    {
        public bool IsGameLoaded
        {
            get => _isGameLoaded;
            private set
            {
                _isGameLoaded = value;
            }
        }

        public ZorkBuilder()
        {
            InitializeComponent();
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
            gameViewModelBindingSource.DataSource = _viewModel;
            _neighborViews.AddRange(new NeighborsUserControl[] { NorthNeighborControl, SouthNeighborControl, EastNeighborControl, WestNeighborControl });
            UpdateTitle();
            CreateGame();
        }

        private void UpdateViewModel()
        {
            StartingLocationComboBox.SelectedIndexChanged -= StartingLocationComboBox_SelectedIndexChanged;
            StartingLocationComboBox.DataSource = _viewModel.Rooms;
            StartingLocationComboBox.SelectedIndexChanged += StartingLocationComboBox_SelectedIndexChanged;

            foreach (var neighborView in _neighborViews)
            {
                neighborView.ViewModel = _viewModel;
            }
        }

        private void CreateGame()
        {
            _viewModel.FullPath = null;
            _viewModel.Game = new Game(new World(), null);
        }

        private void UpdateTitle()
        {
            string filename = IsGameLoaded ? $" - {_viewModel.FileName}" : null;
            Text = $"{AssemblyTitle}{filename}";
        }

        private DialogResult SaveGame()
        {
            if (string.IsNullOrEmpty(_viewModel.FullPath))
            {
                var result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _viewModel.FullPath = saveFileDialog.FileName;
                }
                else if (result == DialogResult.Cancel)
                {
                    return result;
                }
            }

            //Assert.IsFalse(string.IsNullOrEmpty(_viewModel.FullPath));
            _viewModel.SaveGame();
            _viewModel.IsModified = false;
            return DialogResult.OK;

        }
        private void UpdateSelectedRoomNeighbors()
        {
            Room selectedRoom = RoomsListBox.SelectedItem as Room;
            foreach (var neighborView in _neighborViews)
            {
                neighborView.Room = selectedRoom;
            }
        }



        private void _viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            string isModifiedLabel = _viewModel.IsModified ? "Yes" : "No";
            isModifiedToolStripStatusLabel1.Text = $"Modified: {isModifiedLabel}";
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_viewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified project?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveGame() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            CreateGame();
            UpdateViewModel();
            _viewModel.IsModified = true;
            IsGameLoaded = true;
            UpdateTitle();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_viewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified project?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveGame() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _viewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                _viewModel.FullPath = openFileDialog.FileName;
                UpdateTitle();
                UpdateViewModel();
                UpdateSelectedRoomNeighbors();
                StartingLocationComboBox.SelectedItem = _viewModel.Rooms.FirstOrDefault(room => room.Name == _viewModel.StartingLocation);
            }            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_viewModel.FullPath))
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                _viewModel.SaveGame();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _viewModel.FullPath = saveFileDialog.FileName;
                UpdateTitle();
                _viewModel.SaveGame();
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    _viewModel.Rooms.Add(room);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Delete { ((Room)RoomsListBox.SelectedItem).Name }?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Room selectedRoom = (Room)RoomsListBox.SelectedItem;
                _viewModel.Rooms.Remove(selectedRoom);
                RoomsListBox.SelectedItem = _viewModel.Rooms.FirstOrDefault();
                foreach (Room room in _viewModel.Rooms)
                {
                    room.RemoveNeighbor(selectedRoom);
                }

                UpdateViewModel();
                UpdateSelectedRoomNeighbors();
            }
        }
   
        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedRoomNeighbors();
        }

        private void StartingLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_viewModel.StartingLocation == null)
            {
                _viewModel.StartingLocation = "None";
            }
            else
            {
                Room selectedRoom = (Room)StartingLocationComboBox.SelectedItem;
                _viewModel.StartingLocation = selectedRoom.Name;
            }

        }

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        public static GameViewModel _viewModel = new GameViewModel();
        private readonly List<NeighborsUserControl> _neighborViews = new List<NeighborsUserControl>();
        private bool _isGameLoaded;

    }
}