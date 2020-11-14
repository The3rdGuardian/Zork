using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.UserControls
{
    public partial class NeighborsUserControl : UserControl
    {
        public NeighborsUserControl()
        {
            InitializeComponent();
            NoRoom.Name = "None";
        }

        public GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                _viewModel = value;
                if (_viewModel != null && _viewModel.Rooms != null)
                {
                    List<Room> rooms = new List<Room>(_viewModel.Rooms);
                    rooms.Insert(0, NoRoom);
                    NeighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;
                    NeighborComboBox.DataSource = rooms;
                    NeighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;
                }
                else
                {
                    NeighborComboBox.DataSource = new BindingList<Room>(Array.Empty<Room>());
                }
            }
        }

        public Directions Direction
        {
            get => _direction;
            set
            {
                _direction = value;
                DirectionsTextBox.Text = value.ToString();
            }
        }
        public Room Room
        {
            get => _room;
            set
            {
                _room = value;
                if (_room != null)
                {
                    if (_room.Neighbors.TryGetValue(Direction, out Room neighbor))
                    {
                        Neighbor = neighbor;
                    }
                    else
                    {
                        Neighbor = NoRoom;
                    }
                }
                else
                {
                    NeighborComboBox.DataSource = null;
                }
            }
        }

        public Room Neighbor
        {
            get => (Room)NeighborComboBox.SelectedItem;
            set => NeighborComboBox.SelectedItem = value;
        }

        private void NeighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_room != null)
            {
                if (Neighbor == NoRoom)
                {
                    _room.RemoveNeighbor(Direction);
                }
                else
                {
                    _room.AssignNeighbors(Direction, Neighbor);
                }
            }
        }

        private static readonly Room NoRoom = new Room() { Name = "None" };

        private Directions _direction;
        private Room _room;
        private GameViewModel _viewModel;
    }
}


