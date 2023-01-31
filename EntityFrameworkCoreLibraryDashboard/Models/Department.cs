using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreLibraryDashboard.Models;

public class Department : BaseEntity
{
    public string? Name { get; set; }
    // Navigation Property
    public List<Teacher>? Teachers { get; set; }
}
