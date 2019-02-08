using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoTest
{
	public partial class MainPage : ContentPage
	{
        private Object o;
        string d = String.Empty;
        int a, b, c;
        public MainPage()
		{
			InitializeComponent();
            o = new object();
            Analytics.TrackEvent("Show method");


            AppCenter.LogLevel = LogLevel.Verbose;
        }


        private void Show(int result)
        {
            Analytics.TrackEvent("Show method");
            Console.WriteLine(result);
        }

        private int Add(int a, int b)
        {
            Analytics.TrackEvent("Add method");
            return a + b;
        }

        

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Btn_Clicked");

            var re=Add(1,2);
            Show(re);

            a = 0;b = 1;c = 0;
            AppCenter.LogLevel = LogLevel.Debug;
            AppCenter.LogLevel = LogLevel.Error;
          //  c = b / a;
            Console.WriteLine(c);
        }
    }
}
