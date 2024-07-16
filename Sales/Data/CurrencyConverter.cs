using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Globalization;

namespace Sales.Data;

public class CurrencyConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0m;
        }

        //remove special character
        text = text.Substring(1);
        return decimal.Parse(text, NumberStyles.Currency, CultureInfo.InvariantCulture);
    }
}
