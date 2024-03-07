﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApi.DataAccess
{
    [Table("secondarytabletest")]
    public partial class Secondarytabletest
    {
        [Key]
        [Column("secondarytabletestid")]
        public int Secondarytabletestid { get; set; }
        [Column("testid")]
        public int? Testid { get; set; }
        [Column("description")]
        [StringLength(50)]
        public string Description { get; set; } = null!;
        [Column("isactive")]
        public bool? Isactive { get; set; }
        [Column("createddate", TypeName = "timestamp without time zone")]
        public DateTime Createddate { get; set; }

        [ForeignKey("Testid")]
        [InverseProperty("Secondarytabletests")]
        public virtual Test? Test { get; set; }
    }
}
