using Semana14Carlos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana14Carlos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : ContentView
    {
        public PeopleView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelPeople();
        }
    }
}