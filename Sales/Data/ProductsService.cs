using System.Formats.Asn1;
using System.Globalization;
using System.Text;
using CsvHelper;

namespace Sales.Data;

public class ProductsService
{
    public List<Products> GetProducts()
    {
        using (var reader = new StreamReader("Data.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<ProductsMap>(); // Optional: If you have a custom mapping

            var products = csv.GetRecords<Products>().ToList();
            return products;
        }
    }
}


