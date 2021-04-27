using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationDrawer
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void button1_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();

        }
        private void button2_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleSecondaryDrawer();
        }
    }
}
