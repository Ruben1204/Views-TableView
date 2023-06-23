using ControlesTipoVista.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.ViewModel
{
    public class ListViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Propiedad para ejemplo de Picker

        private Robot selectedRobot;

        public Robot SelectedRobot
        {
            get
            {
                return selectedRobot;
            }
            set
            {
                if(selectedRobot != value)
                {
                    selectedRobot = value;
                    OnPropertyChanged(nameof(SelectedRobot));
                    OnPropertyChanged("SelectedRobotIndex");
                }
            }
        }

        public int SelectedRobotIndex
        {
            get
            {
                return Robots.IndexOf(SelectedRobot);
            }
        }

        private List<Robot> _robots;

        public List<Robot> Robots
        {
            get
            {
                return _robots;
            }
            set
            {
                _robots = value;
                OnPropertyChanged(nameof(Robots));

            }
        }

        public ListViewModel()
        {
            Robots = new List<Robot>
            {
                new Robot {Nombre = "Robot 1", Imagen = "dotnet_bot.png", Peso = 25.5},
                new Robot {Nombre = "Robot 2", Imagen = "dotnet_bot.png", Peso = 10.5},
                new Robot {Nombre = "Robot 3", Imagen = "dotnet_bot.png", Peso = 20.5},
                new Robot {Nombre = "Robot 1", Imagen = "dotnet_bot.png", Peso = 25.5},
                new Robot {Nombre = "Robot 2", Imagen = "dotnet_bot.png", Peso = 10.5},
                new Robot {Nombre = "Robot 3", Imagen = "dotnet_bot.png", Peso = 20.5},
                new Robot {Nombre = "Robot 1", Imagen = "dotnet_bot.png", Peso = 25.5},
                new Robot {Nombre = "Robot 2", Imagen = "dotnet_bot.png", Peso = 10.5},
                new Robot {Nombre = "Robot 3", Imagen = "dotnet_bot.png", Peso = 20.5},

            };
        }
    }
}
