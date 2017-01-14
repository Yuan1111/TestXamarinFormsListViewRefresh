using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TestXamarinFormsListViewRefresh
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Button btn = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Center,
                Text="Go to ListPage"
            };
            btn.Clicked += Btn_Clicked;
            Content = new StackLayout
            {
                Children = {
                   btn
                }
            };
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new ListViewPage()) { BarBackgroundColor = Color.FromHex("3BB777"), BarTextColor = Color.White });
        }
    }
}
