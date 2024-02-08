using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TR.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vimc : ContentPage
    {
        public Vimc()
        {
            InitializeComponent();
            BindingContext = new VMimc(Navigation);
        }
    }
}