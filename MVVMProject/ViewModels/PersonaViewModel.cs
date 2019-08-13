//using MVVMProject.Connectors;
using MVVMProject.Core.Commands;
using MVVMProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVMProject.Core;
using MVVMProject.Connectors;

namespace MVVMProject.ViewModels
{
    public class PersonaViewModel : IGeneric
    {
        private PersonaCollection _listaPersonas = new PersonaCollection();
       
        public PersonaCollection ListaPersonas
        {
            get { return _listaPersonas; }
            set
            {
                _listaPersonas = value;
                if(value != null && value.Count > 0)
                {
                    CurrentPersona = value[0];
                }
                RaisePropertyChanged("ListaPersonas");
            }
        }
        private Persona _currentPersona;
        public Persona CurrentPersona
        {
            get { return _currentPersona; }
            set
            {
                _currentPersona = value;
                RaisePropertyChanged("CurrentPersona");
                RaisePropertyChanged("CanShowInfo");
            }
        }
        private DbConnector connector;

        public DbConnector Connector
        {
            get { return connector; }
            set { connector = value; }
        }

        private ICommand _listarPersonasCommand;
        public ICommand ListarPersonasCommand
        {
            get
            {
                if (_listarPersonasCommand == null)
                    _listarPersonasCommand = new RelayCommand(new Action(ListarPersonas));
                return _listarPersonasCommand;
            }
        }

        private ICommand _verInfoCommand;
        public ICommand VerInfoCommand
        {
            get
            {
                if (_verInfoCommand == null)
                    //ver Info se deshabilitara si no tiene ningun objeto listado en la lista 
                    _verInfoCommand = new RelayCommand(new Action(VerInfo), () => CanShowInfo );
                return _verInfoCommand;
            }
        }

        private bool CanShowInfo
        {
            get
            {
                return CurrentPersona != null;
            }
        }

        private void ListarPersonas()
        {
            ListaPersonas = App.DbConnector.listarPersonas();
            
            
        }
        private void VerInfo()
        {
            MessageBox.Show(CurrentPersona.Nombre);
        }

    }
}
