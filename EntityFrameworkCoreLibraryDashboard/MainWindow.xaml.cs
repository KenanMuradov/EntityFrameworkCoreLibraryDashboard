using EntityFrameworkCoreLibraryDashboard.Commands;
using EntityFrameworkCoreLibraryDashboard.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EntityFrameworkCoreLibraryDashboard;


public partial class MainWindow : Window
{
    private IConfiguration? configuration = null;
    private LibraryDbContext? context = null;
    public ICommand BooksCommand { get; set; }
    public ICommand AuthorsCommand { get; set; }
    public ICommand CategoriesCommand { get; set; }
    public ICommand DepartmentsCommand { get; set; }
    public ICommand GroupsCommand { get; set; }
    public ICommand FacultiesCommand { get; set; }
    public ICommand StudentsCommand { get; set; }
    public ICommand TeachersCommand { get; set; }
    public ICommand LibsCommand { get; set; }
    public ICommand ThemesCommand { get; set; }
    public ICommand PressesCommand { get; set; }
    public ICommand T_CardsCommand { get; set; }
    public ICommand S_CardsCommand { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        context= new();
        BooksCommand = new RelayCommand(ExecuteBooksCommand);
        AuthorsCommand = new RelayCommand(ExecuteAuthorsCommand);
        CategoriesCommand = new RelayCommand(ExecuteCategoriesCommand);
        DepartmentsCommand = new RelayCommand(ExecuteDepartmentsCommand);
        GroupsCommand = new RelayCommand(ExecuteGroupsCommand);
        FacultiesCommand = new RelayCommand(ExecuteFacultiesCommand);
        StudentsCommand = new RelayCommand(ExecuteStudentsCommand);
        TeachersCommand = new RelayCommand(ExecuteTeachersCommand);
        LibsCommand = new RelayCommand(ExecuteLibsCommand);
        ThemesCommand = new RelayCommand(ExecuteThemesCommand);
        PressesCommand = new RelayCommand(ExecutePressesCommand);
        T_CardsCommand = new RelayCommand(ExecuteT_CardsCommand);
        S_CardsCommand = new RelayCommand(ExecuteS_CardsCommand);
    }

    private async void ExecuteS_CardsCommand(object? obj)
    {
        var list = await context.S_Cards.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Id_Book, x.Id_Lib, x.Id_Student, x.DateOut, x.DateIn });
    }

    private async void ExecuteT_CardsCommand(object? obj)
    {
        var list = await context.T_Cards.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Id_Book, x.Id_Lib, x.Id_Teacher, x.DateOut, x.DateIn });

        ;
    }

    private async void ExecutePressesCommand(object? obj)
    {
        var list = await context.Presses.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Name });
    }

    private async void ExecuteThemesCommand(object? obj)
    {
        var list = await context.Themes.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Name });
    }

    private async void ExecuteLibsCommand(object? obj)
    {
        var list = await context.Libs.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName });
    }

    private async void ExecuteTeachersCommand(object? obj)
    {
        var list = await context.Teachers.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName, x.Id_Dep });
    }

    private async void ExecuteStudentsCommand(object? obj)
    {
        var list = await context.Students.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName, x.Id_Group, x.Term });
    }

    private async void ExecuteFacultiesCommand(object? obj)
    {
        var list = await context.Faculties.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Name });
    }

    private async void ExecuteGroupsCommand(object? obj)
    {
        var list = await context.Groups.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Name, x.Id_Faculty });
    }

    private async void ExecuteDepartmentsCommand(object? obj)
    {
        var list = await context.Departments.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Name });
    }

    private async void ExecuteCategoriesCommand(object? obj)
    {
        var list = await context.Categories.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Name });
    }

    private async void ExecuteAuthorsCommand(object? obj)
    {
        var list = await context.Authors.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName });
    }

    private async void ExecuteBooksCommand(object? obj)
    {

        var list = await context.Books.ToListAsync();

        DataList.ItemsSource = list.Select(x => new { x.Id, x.Name, x.Pages, x.YearPress, x.Id_Category, x.Id_Press, x.Id_Author, x.Id_Theme, x.Comment, x.Quantity });
    }

}
