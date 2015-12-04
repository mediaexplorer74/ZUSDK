﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace System.Windows
{
	 /// <summary>
    /// Will return b-a
    /// </summary>
	public class BMinusAFunctionConverter : IValueConverter
	{
		public double A { get; set; }
		//public double B { get; set; }

		#region IValueConverter Members

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			//double a = GetDoubleValue( parameter, A );

			//double x = GetDoubleValue( value, 0.0 );

			//return ( a * x ) + B;

			double scrollBarWidth = GetDoubleValue(parameter, A);
			double listBoxItemWidth = GetDoubleValue(value, 0.0);

			return (listBoxItemWidth - scrollBarWidth);
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			//double a = GetDoubleValue( parameter, A );

			//double y = GetDoubleValue( value, 0.0 );

			//return ( y - B ) / a;

			throw new NotImplementedException();
		}

		#endregion


		private double GetDoubleValue(object parameter, double defaultValue)
		{
			double a;
			if (parameter != null)
				try
				{
					a = System.Convert.ToDouble(parameter);
				}
				catch
				{
					a = defaultValue;
				}
			else
				a = defaultValue;
			return a;
		}
	} // class
} // namespace
