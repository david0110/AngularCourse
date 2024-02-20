using System;
using System.Collections.Generic;

namespace DatabaseConnection.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public decimal Buyprice { get; set; }

    public decimal Sellprice { get; set; }

    public decimal Margin { get; set; }

    public bool Issubtype { get; set; }

    public DateTime Creationdate { get; set; }

    public DateTime Updatedate { get; set; }

    public bool Isactive { get; set; }
}
