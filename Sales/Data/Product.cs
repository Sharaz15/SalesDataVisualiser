using System.ComponentModel;
using CsvHelper.Configuration.Attributes;

namespace Sales.Data;

public class Products
{
    public Products()
    {

    }
    [Name("Segment")]
    public string Segment { get; set; }

    [Name("Country")]
    public string Country { get; set; }

    [Name("Product")]
    public string Product { get; set; }

    [Name("Discount Band")]
    public string DiscountBand { get; set; }

    [Name("Units Sold")]
    public decimal UnitsSold { get; set; }

    [Name("Manufacturing Price")]
    [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CurrencyConverter))]
    public decimal ManufacturingPrice { get; set; }

    [Name("Sale Price")]
    [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CurrencyConverter))]
    public decimal SalePrice { get; set; }

    [Name("Date")]
    [Format("MM/dd/yyyy")]
    public DateTime Date { get; set; }
}
