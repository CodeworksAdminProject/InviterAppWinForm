using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace invAppMobail
{
	public partial class MainPage : ContentPage
	{
        
        public MainPage()
		{
			InitializeComponent();
        }
        private void BarcodeRequest_Click(object sender, System.EventArgs e)
        {
            ToFirstPage(sender,e);

        }
        private async void ToFirstPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstPage());

        }

        private void NumberRequest_Click(object sender, System.EventArgs e)
        {
           // brr.Focus();
          //  brr.Text = "Искать в базе (фильтр)";
        }
        private void Inventory_Click(object sender, System.EventArgs e)
        {
          //  brr.Focus();
          //  brr.Text = "Инвентаризация";
        }
        private void Settings_Click(object sender, System.EventArgs e)
        {
          //  brr.Focus();
          //  brr.Text = "Настройки";
        }
        private void Exit_Click(object sender, System.EventArgs e)
        {
          //  brr.Focus();
          //  brr.Text = "Выход";
        }
    }
}
