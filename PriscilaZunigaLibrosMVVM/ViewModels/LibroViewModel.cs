using PriscilaZunigaLibrosMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaZunigaLibrosMVVM.ViewModels
{
    public class LibroViewModel : INotifyPropertyChanged
    {
        private PZLibro _libro;
        public PZLibro Libro
        {
            get { return _libro; }
            set { _libro = value; 
            OnPropertyChanged(nameof(Libro));}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
