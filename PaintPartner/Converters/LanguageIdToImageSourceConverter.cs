using System;
using System.Globalization;
using System.Windows.Data;

using PaintPartner.DataModels;

namespace PaintPartner.Converters
{
    public class LanguageIdToImageSourceConverter : IValueConverter
    {
        private const string RootPath = "./Resources/Languages";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DataLanguage dataLanguage)
            {
                return RootPath + "/" + dataLanguage.Code + ".jpg";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
