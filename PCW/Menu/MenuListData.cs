using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace PCW
{
	public class BooleanInverter : IValueConverter
	{
		#region IValueConverter implementation
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return !(bool)value;
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return !(bool)value;
		}
		#endregion

	}
	public class MenuListData : List<MenuItem>
	{
		public MenuListData (string str)
		{
			if (str == "coach") {
                Add(new MenuItem (){ Title = "Dashboard", Des = "Home", TargetType = typeof(Dashboard) });
                Add(new MenuItem() { Title = "Teams", Des = "Home", TargetType = typeof(Temp) });
                Add(new MenuItem() { Title = "Athletes", Des = "Home", TargetType = typeof(MyAthletes) });
                Add(new MenuItem() { Title = "Contacts", Des = "Home", TargetType = typeof(Dashboard) });
                Add(new MenuItem() { Title = "Workouts", Des = "Home", TargetType = typeof(Dashboard) });
                Add(new MenuItem() { Title = "Calendars", Des = "Home", TargetType = typeof(Dashboard) });
                Add(new MenuItem() { Title = "Polls", Des = "Home", TargetType = typeof(Dashboard) });
                Add(new MenuItem() { Title = "Games", Des = "Home", TargetType = typeof(Dashboard) });
                Add(new MenuItem() { Title = "Settings", Des = "Home", TargetType = typeof(Dashboard) });
            } else if (str == "athlete") {
            } 
		}
	}
}