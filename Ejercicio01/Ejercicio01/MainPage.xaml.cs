using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio01
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayoutDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new AbsoluteLayoutDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new RelativeLayoutDemo());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GridDemo());

            };
            Item5.Clicked += async (sender, e) =>
            {
                
                await Navigation.PushModalAsync(new ScrollViewDemo());

            };


            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayoutCode());

            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new AbsoluteLayoutCode());
            };
            Item8.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new RelativeLayoutCode());

            };
            Item9.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GridCode());

            };
            Item10.Clicked += async (sender, e) =>
            {

                await Navigation.PushModalAsync(new ScrollViewCode());

            };


        }
	}
}
