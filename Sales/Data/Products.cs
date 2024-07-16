﻿using System.ComponentModel;

namespace Sales.Data;

public class Products
{
    public string Segment { get; set; }

    public string Country { get; set; }

    public string Product { get; set; }

    public string DiscountBand { get; set; }

    public decimal UnitsSold { get; set; }

    public decimal ManufacturingPrice { get; set; }

    public decimal SalePrice { get; set; }

    public DateTime Date { get; set; }
}
