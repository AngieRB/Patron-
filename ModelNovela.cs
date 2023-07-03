using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ViewMVM.Models;
using Xamarin.Forms;


namespace ViewMVM.ViewModels
{
    //creamos una clase ModelNovela la cual heredara de INotifyPropertyChanged
    public  class ModelNovela: INotifyPropertyChanged
    {
        public ModelNovela()
        {
            this.Novela = new Novela();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        //creamos dos propiedades extensdidas la cuales son Novela y Descripcion

        private Novela _novela;

        public Novela Novela
        {
            get { return this._novela; }
            set
            {
                this._novela = value;
                OnPropertyChanged("Novela");
            }
        }
        private String _Descripcion;
        public String Descripcion
        {
            get { return this._Descripcion; }
            set
            {
                this._Descripcion = value;
                OnPropertyChanged("Descripcion");
            }
        }

        //creamos un metodo mostrardescripcion al que llamaremos desde el command del boton MostaraNovela
        public String MostrarDescripcion()
        {
            return "Novela: " + this.Novela.Titulo +
                ", Autor: " + this.Novela.Autor +
                ", Genero: " + this.Novela.Genero;
        }

        public Command MostrarNovela
        {
            get
            {
                return new Command(() => {
                    Descripcion = MostrarDescripcion();
                });
            }
        }

    }
}

 