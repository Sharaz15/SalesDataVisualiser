using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace Sales.Data;

public class TrimStringConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        //remove any white spaces
        return decimal.Parse(text?.Replace(" ", "").Trim());
    }
}
