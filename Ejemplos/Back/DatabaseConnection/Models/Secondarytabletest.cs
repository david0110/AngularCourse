using System;
using System.Collections.Generic;

namespace DatabaseConnection.Models;

public partial class Secondarytabletest
{
    public int Secondarytabletestid { get; set; }

    public int? Testid { get; set; }

    public string Description { get; set; } = null!;

    public bool? Isactive { get; set; }

    public DateTime Createddate { get; set; }

    public virtual Test? Test { get; set; }
}
