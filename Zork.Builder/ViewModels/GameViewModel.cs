using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork.Builder.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string FullPath { get; set; }

        public string FileName => FullPath != null ? Path.GetFileName(FullPath) : "Untitled";

        public BindingList<Room> Rooms { get; set; }

        public string StartingLocation 
        {
            get => _game?.World?.StartingLocation;
            set
            {
                _game.World.StartingLocation = value;
            }
        }

        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    if(_game != null)
                    {
                        _game.PropertyChanged -= Game_PropertyChanged;
                        _game.World.PropertyChanged -= Game_PropertyChanged;
                        foreach (Room room in _game.World.Rooms)
                        {
                            room.PropertyChanged -= Game_PropertyChanged;
                        }
                    }

                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                        _game.PropertyChanged += Game_PropertyChanged;
                        _game.World.PropertyChanged += Game_PropertyChanged;
                        foreach (Room room in _game.World.Rooms)
                        {
                            room.PropertyChanged += Game_PropertyChanged;
                        }
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());

                    }
                }
            }
        }

        private void Game_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            IsModified = true;
            PropertyChanged?.Invoke(this, e);
        }

        public string WelcomeMessage
        {
            get => _game.WelcomeMessage;
            set => _game.WelcomeMessage = value; 
        }

        public string ExitMessage
        {
            get => _game.ExitMessage;
            set => _game.ExitMessage = value;
        }

        public bool IsModified { get; set; }
        public GameViewModel(Game game = null) => Game = game;

        public void SaveGame()
        {
            JsonSerializer jsonSerializer = new JsonSerializer() { Formatting = Formatting.Indented };

            using (StreamWriter streamWriter = new StreamWriter(FullPath))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                jsonSerializer.Serialize(jsonWriter, _game);
            }

            IsModified = false;
        }

        private World _world;
        private Game _game;
    }
}