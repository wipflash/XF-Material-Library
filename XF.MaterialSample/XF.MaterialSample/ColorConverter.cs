﻿using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace XF.MaterialSample
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color;

            if(value is DynamicResource res)
            {
                color = (Color)Application.Current.Resources[res.Key];
            }

            else
            {
                color = (Color)value;
            }

            var red = (int)(color.R * 255);
            var green = (int)(color.G * 255);
            var blue = (int)(color.B * 255);
            var alpha = (int)(color.A * 255);
            return $"#{red:X2}{green:X2}{blue:X2}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
