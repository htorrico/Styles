using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitCode());

            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlCode());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());

            };
            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitCode());

            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());

            };
        
            Item9.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());

            };
            Item10.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalCode());

            };
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());

            };
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceCode());

            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());

            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicCode());

            };
            Item15.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ClassDemo());

            };
        }
    }
}
