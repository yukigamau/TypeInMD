using System;
using TypeInMD.Core.Models;
using TypeInMD.Core.Utilities;
using Windows.UI.Xaml.Data;

namespace TypeInMD.Core.Converters
{
    public class ShortcutKeyToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value is ShortcutKey key ? Common.GetShortcutKeyText(key) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
