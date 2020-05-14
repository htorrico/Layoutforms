using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Ejercicio01
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new  NavigationPage( new MainPage());
            //MainPage = new StackLayoutDemo();
            //MainPage = new RelativeLayoutDemo();
            //MainPage = new GridDemo();
            //MainPage = new AbsoluteLayoutDemo();

            
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
