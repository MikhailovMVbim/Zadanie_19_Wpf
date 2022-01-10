using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zadanie_19_Wpf.Models;

namespace Zadanie_19_Wpf.ViewModels
{
    class MainWindowViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string PropertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        private double dlina;
        public double Dlina
        {
            get => dlina;
            set
            {
                dlina = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalcDlina { get; }
        private void OnCalcDlinaExecute (object p)
        {
            Dlina = Calc.CalcDl(Radius);
        }

        private bool CanCalcDlinaExecuted (object p)
        {
            if (Radius != 0)
            {
                return true;
            }
            else
                return false;
        }

        public MainWindowViewModel ()
        {
            CalcDlina = new RelayCommand(OnCalcDlinaExecute, CanCalcDlinaExecuted);
        }
            
    }
}
