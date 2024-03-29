﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamlSamples.Converters
{
    class DoubleToIntConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double multiplier;
            if (!Double.TryParse(parameter as string, out multiplier))
                multiplier = 1;
            return (int)Math.Round(multiplier * (double)value);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double divider;
            if (!Double.TryParse(parameter as string, out divider))
                divider = 1;
            return ((double)(int)value) / divider;
        }
    }
}
