using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace invAppMobail
{
	
	public partial class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			InitializeComponent ();
		}
        private void Back_Click(object sender, System.EventArgs e)
        {
            ToMainPage(sender, e);
        }
        public async void ToMainPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        private void BarcodeRequest_Click(object sender, System.EventArgs e)
        {
            brr.Focus();
            brr.Text = "Искать в базе (скан штрихкода)";
        }
    }
}