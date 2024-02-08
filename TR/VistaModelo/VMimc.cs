using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TR.VistaModelo
{
    public class VMimc : BaseViewModel
    {
        #region VARIABLES
        bool _rimc = false;
        bool _rfcn = false;
        bool _negativo = false;

        double _peso;
        double _altura;
        string _resultado;


        #endregion
        #region CONSTRUCTOR
        public VMimc(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public bool Rimc
        {
            get { return _rimc; }
            set
            {
                if (_rimc != value)
                {
                    _rimc = value;
                    OnpropertyChanged(nameof(Rimc));
                }
            }
        }
        public bool Rfcn
        {
            get { return _rfcn; }
            set
            {
                if (_rfcn != value)
                {
                    _rfcn = value;
                    OnpropertyChanged(nameof(Rfcn));
                }
            }
        }

        public double Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public double Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }

        public bool Negativo
        {
            get { return _negativo; }
            set { SetValue(ref _negativo, value); }
        }
        #endregion
        #region PROCESOS
        public async Task CalcularIMC()
        {
            double Resu = (Peso / (Altura * Altura));
            if (Resu >= 20 && Resu <= 30)
            {
                DisplayAlert("Alerta","IMC Normal","Ok");
                Negativo = false;
            }
            if (Resu > 30)
            {
                DisplayAlert("Alerta", "IMC Alto", "Ok");
                Negativo=true;
            }
            if (Resu < 20)
            {
                DisplayAlert("Alerta", "IMC Bajo", "Ok");
                Negativo = true;
            }

            Resultado = $"{Resu}";
        }
        public void procesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Calcularcommand => new Command(async () => await CalcularIMC());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        #endregion
    }
}
