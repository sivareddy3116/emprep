// See https://aka.ms/new-console-template for more information
using ConAppTwo;

Console.WriteLine("Hello, World!");
List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Siva", Designation = "Manager", Doj = new DateTime(2022, 5, 12) },
            new Employee { Id = 2, Name = "Liki", Designation = "TL", Doj = new DateTime(2021, 6, 10) },
            new Employee { Id = 3, Name = "Ramya", Designation = "HR", Doj = new DateTime(2020, 5, 16) },
            new Employee { Id = 4, Name = "Pavani", Designation = "Sr. Developer", Doj = new DateTime(2020, 10, 10) },
            new Employee { Id = 5, Name = "Girija", Designation = "Associate", Doj = new DateTime(2019, 5, 11) },
        };
Console.WriteLine("ID\t NAme \t Designation \t Date ojf joining");
foreach (Employee emp in employees)
{
    Console.WriteLine(emp.Id + "\t \t");
    Console.WriteLine(emp.Name + "\t \t");
    Console.WriteLine(emp.Designation + "\t \t");
    Console.WriteLine(emp.Doj.ToLongDateString());
    Console.WriteLine("\n");
}
Console.ReadKey();
