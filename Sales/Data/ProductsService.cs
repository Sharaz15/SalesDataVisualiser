using System.Formats.Asn1;
using System.Globalization;
using System.Text;
using CsvHelper;

namespace Sales.Data;

public class ProductsService
{
    private readonly ILogger<ProductsService> _logger;

    public ProductsService(ILogger<ProductsService> logger)
    {
        _logger = logger;
    }

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
            // Log the exception and handle it as necessary
            _logger.LogError(ex, "Error reading from CSV");
            throw new Exception(ex.Message, ex);
        }
    }
}


