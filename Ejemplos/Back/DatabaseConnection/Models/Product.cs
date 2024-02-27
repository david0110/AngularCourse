﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConnection.Models;

[Table("products")]
public partial class Product
{
    [Key]
    [Column("productid")]
    public int Productid { get; set; }

    [Required]
    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [Column("description")]
    [StringLength(50)]
    public string Description { get; set; }

    [Required]
    [Column("code")]
    [StringLength(10)]
    public string Code { get; set; }

    [Column("buyprice")]
    public decimal Buyprice { get; set; }

    [Column("sellprice")]
    public decimal Sellprice { get; set; }

    [Column("margin")]
    public decimal Margin { get; set; }

    [Column("issubtype")]
    public bool Issubtype { get; set; }

    [Column("creationdate", TypeName = "timestamp without time zone")]
    public DateTime Creationdate { get; set; }

    [Column("updatedate", TypeName = "timestamp without time zone")]
    public DateTime Updatedate { get; set; }

    [Column("isactive")]
    public bool Isactive { get; set; }
}
