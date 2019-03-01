﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Widget;
using Xamarin.Forms;

namespace MsgToast
{
    public partial class MainPage : ContentPage , IMensagem
    {
        void Long_Clicked(object sender, System.EventArgs e)
        {
            LongTime("Testando o Tempo Longo");
        }

        void Short_Clicked(object sender, System.EventArgs e)
        {
            ShortTime("Testando o Tempo Curto");
        }

        public void LongTime(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Long).Show();
        }

        public void ShortTime(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Short).Show();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
