using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UWPDisplayActionSheet
{
    public class Helper
    {
        public static class CurrentPage
        {
            public static Page Instance
            {
                get
                {
                    Page ret = null;
                    if (Application.Current.MainPage.Navigation.NavigationStack != null)
                        ret = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

                    if (ret == null)
                        ret = Application.Current.MainPage;

                    return ret;
                }
            }
        }

        public static async Task ProcessData()
        {
            // save some data

            try
            {
                // crash here

                var result = await CurrentPage.Instance.DisplayActionSheet("currentpage", "ok", null, new string[] { "button" });

                result = await Application.Current.MainPage.DisplayActionSheet("hi", "ok", null, new string[] { "button1" });
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("error", ex.Message, "ok");
            }
        }
    }
}
