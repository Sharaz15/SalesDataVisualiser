using System.Formats.Asn1;
using System.Globalization;
using System.Text;
using CsvHelper;

namespace Sales.Data;

public class ProductsService
{
    public List<Products> GetProducts()
    {
        try
        {
            using (var reader = new StreamReader("Data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ProductsMap>(); // Optional: If you have a custom mapping

                var products = csv.GetRecords<Products>().ToList();
                return products;
            }
        }
        catch (Exception ex)
        {
            // Log the exception or handle it as necessary
            throw new Exception("Error loading products from CSV please see log file", ex);
        }
    }
}


