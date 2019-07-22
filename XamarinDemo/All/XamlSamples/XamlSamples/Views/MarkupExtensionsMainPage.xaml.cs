using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlSamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarkupExtensionsMainPage : ContentPage
    {
        public MarkupExtensionsMainPage()
        {
            InitializeComponent();
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            BindingContext = this;
        }
        public ICommand NavigateCommand { private set; get; }
    }
}