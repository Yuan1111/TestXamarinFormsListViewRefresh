using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestXamarinFormsListViewRefresh
{
    public class OtherPage : ContentPage
    {
        public OtherPage()
        {
            Task.Delay(5000).ContinueWith((t) =>
            {
                MessagingCenter.Send<object>(this, "TestRefresh");
            });
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }
                }
            };
        }
    }
}
