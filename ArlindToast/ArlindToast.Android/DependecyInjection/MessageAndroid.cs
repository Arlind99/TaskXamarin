using System;
using Android.App;
using Android.Widget;
using ArlindToast.Droid.DependecyInjection;
using ArlindToast.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
namespace ArlindToast.Droid.DependecyInjection
{
    public class MessageAndroid : IMessage
    {
            public MessageAndroid()
        {

        }
        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}
