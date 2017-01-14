using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TestXamarinFormsListViewRefresh
{
    public class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            ListView listView = new ListView
            {
                IsPullToRefreshEnabled=true
            };

            MessagingCenter.Subscribe<object>(this, "TestRefresh", (sender) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    listView.IsRefreshing = false;
                });
            });

            listView.Refreshing += ListView_Refreshing;
              Content = new StackLayout
            {
                Children = {
                   listView
                }
            };
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OtherPage());
        }
    }
}
