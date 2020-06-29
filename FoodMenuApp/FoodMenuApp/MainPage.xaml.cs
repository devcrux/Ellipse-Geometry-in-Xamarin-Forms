using FoodMenuApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodMenuApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenOrder(object sender, EventArgs e)
        {
            if(OrderView.TranslationX >= 150)
            {
                Action<double> callback = input => OrderView.TranslationX = input;
                OrderView.Animate("anim", callback, 150, 0, 16, 300, Easing.CubicInOut);
            }
        }

        private void CloseOrder(object sender, EventArgs e)
        {
            if (OrderView.TranslationX == 0)
            {
                Action<double> callback = input => OrderView.TranslationX = input;
                OrderView.Animate("anim", callback, 0, 150, 16, 300, Easing.CubicOut);
            }
        }

        private void AddOrder(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as Food;
            vm.AddOrder(item);
        }
    }
}
