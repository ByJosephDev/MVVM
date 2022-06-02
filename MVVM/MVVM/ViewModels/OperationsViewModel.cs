using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
	public class OperationsViewModel : ViewModelBase
	{

        #region Propiedades

        double valor1;

        public double Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        double valor2;

        public double Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        double suma;

        public double ResultSuma
        {
            get { return suma; }
            set
            {
                if (suma != value)
                {
                    suma = value;
                    OnPropertyChanged();
                }
            }
        }

        double resta;

        public double ResultResta
        {
            get { return resta; }
            set
            {
                if (resta != value)
                {
                    resta = value;
                    OnPropertyChanged();
                }
            }
        }

        double multi;

        public double ResultMulti
        {
            get { return multi; }
            set
            {
                if (multi != value)
                {
                    multi = value;
                    OnPropertyChanged();
                }
            }
        }

        double divi;

        public double ResultDivi
        {
            get { return divi; }
            set
            {
                if (divi != value)
                {
                    divi = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region Comandos

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }

        #endregion

        #region Constructor

        public OperationsViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultSuma = System.Math.Round(valor1 + valor2, 2);
            });

            Restar = new Command(() =>
            {
                ResultResta = System.Math.Round(valor1 - valor2, 2);
            });

            Multiplicar = new Command(() =>
            {
                ResultMulti = System.Math.Round(valor1 * valor2, 2);
            });

            Dividir = new Command(() =>
            {
                ResultDivi = System.Math.Round(valor1 / valor2, 2);
            });

        }

        #endregion

    }
}

