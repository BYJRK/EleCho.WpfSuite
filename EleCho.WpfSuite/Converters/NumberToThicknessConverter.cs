﻿using System;
using System.Globalization;
using System.Windows;

namespace EleCho.WpfSuite
{
    public class NumberToThicknessConverter : SingletonValueConverterBase<NumberToThicknessConverter>
    {
        public override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            try
            {
                var current = System.Convert.ToDouble(value);

                return new Thickness(current);
            }
            catch
            {
                return DependencyProperty.UnsetValue;
            }
        }
    }
}
