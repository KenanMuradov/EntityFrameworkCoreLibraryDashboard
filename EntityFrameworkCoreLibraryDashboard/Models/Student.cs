using EntityFrameworkCoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreLibraryDashboard.Models;

public class Student : BaseEntity
{ 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id_Group { get; set; }
    public Term Term { get; set; }
    // Navigation Property
    public Group? Group { get; set; }
    public List<S_Card>? S_Cards { get; set; }
}
