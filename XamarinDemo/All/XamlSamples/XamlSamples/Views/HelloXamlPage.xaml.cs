﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlSamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloXamlPage : ContentPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();
        }
    }
}