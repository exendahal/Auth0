using Auth0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Auth0.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MyPageViewModel myPageViewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = myPageViewModel = new MyPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            myPageViewModel.OnPageAppearingCommand.Execute(null);
        }
    }
}