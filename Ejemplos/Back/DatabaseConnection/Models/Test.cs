using System;
using System.Collections.Generic;

namespace DatabaseConnection.Models;

public partial class Test
{
    public int Testid { get; set; }

    public string Name { get; set; } = null!;

    public string? Lastname { get; set; }

    public virtual ICollection<Secondarytabletest> Secondarytabletests { get; set; } = new List<Secondarytabletest>();
}
