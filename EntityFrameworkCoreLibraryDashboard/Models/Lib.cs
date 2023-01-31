using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreLibraryDashboard.Models;

public class Lib : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Navigation Property
    public List<T_Card>? T_Cards { get; set; }
    public List<S_Card>? S_Cards { get; set; }
}
