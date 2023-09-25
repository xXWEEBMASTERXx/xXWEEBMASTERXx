using Berek2020;
using System;
using System.Collections.Generic;

// 1. feladat
Console.WriteLine("1. feladat:");
// 2. feladat
List<Employee> employees = ReadEmployees();
// 3. feladat
Console.WriteLine("3. feladat:");
Console.WriteLine("A forrásállományban {employees.Count} dolgozó adata található.");

// 4. feladat
Console.WriteLine("4. feladat:");
float averageSalary = CalculateAverageSalary(employees);
Console.WriteLine($"A 2020-as átlagbér: {averageSalary:F1} ezer forint.");

// 5. feladat
Console.WriteLine("5. feladat:");
List<string> departments = GetDepartments(employees);
foreach (string department1 in departments)
{
    Console.WriteLine(department1);
}

// 6. feladat
Console.WriteLine("6. feladat:");
string department = Employee.GetDepartmentFromUser();
Employee highestPaidEmployee = Employee.GetHighestPaidEmployee(employees, department);
if (highestPaidEmployee != null)
{
    Console.WriteLine(highestPaidEmployee);
}
else
{
    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
}


static List<Employee> ReadEmployees()
{
    StreamReader reader = new StreamReader("berek2020.txt");

    List<Employee> employees = new List<Employee>();
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] columns = line.Split(';');

        Employee employee = new Employee(
            columns[0],
            columns[1],
            columns[2],
            int.Parse(columns[3]),
            int.Parse(columns[4]));

        employees.Add(employee);
    }

    reader.Close();

    return employees;
}

static float CalculateAverageSalary(List<Employee> employees)
{
    int totalSalary = 0;

    int employeeCount = employees.Count;

    for (int i = 0; i < employeeCount; i++)
    {
        totalSalary += employees[i].Salary;
    }

    return (float)totalSalary / employeeCount;
}

static List<string> GetDepartments(List<Employee> employees)
{
    List<string> departments = new List<string>();

    for (int i = 0; i < employees.Count; i++)
    {
        if (!departments.Contains(employees[i].Department))
        {
            departments.Add(employees[i].Department);
        }
    }

    return departments;
}
// 8. feladat
Console.WriteLine("8. feladat:");

List<string> _ = GetDepartments(employees);

Dictionary<string, Employee> lowestPaidEmployees = new Dictionary<string, Employee>();

for (int i = 0; i < departments.Count; i++)
{
    string department2 = departments[i];
    Employee lowestPaidEmployee = null;
    for (int j = 0; j < employees.Count; j++)
    {
        if (employees[j].Department == department2 &&
            (lowestPaidEmployee == null || employees[j].Salary < lowestPaidEmployee.Salary))
        {
            lowestPaidEmployee = employees[j];
        }
    }

    lowestPaidEmployees[department2] = lowestPaidEmployee;
}

foreach (var entry in lowestPaidEmployees)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}
