using System;
using CsvHelper.Configuration;

namespace Sales.Data
{
    public sealed class ProductsMap : ClassMap<Products>
    {
        public ProductsMap()
        {
            Map(m => m.Segment).Name("Segment");
            Map(m => m.Country).Name("Country");
            Map(m => m.Product).Name("Product");
            Map(m => m.DiscountBand).Name("Discount Band");
            Map(m => m.UnitsSold).Name("Units Sold").TypeConverter<TrimStringConverter>();
            Map(m => m.ManufacturingPrice).Name("Manufacturing Price").TypeConverter<CurrencyConverter>();
            Map(m => m.SalePrice).Name("Sale Price").TypeConverter<CurrencyConverter>();
            Map(m => m.Date).Name("Date").TypeConverterOption.Format("MM/dd/yyyy");
        }
    }

}

