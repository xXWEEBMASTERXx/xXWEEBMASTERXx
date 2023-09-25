namespace Berek2020
{
    class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int EntryYear { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string gender, string department, int entryYear, int salary)
        {
            this.Name = name;
            this.Gender = gender;
            this.Department = department;
            this.EntryYear = entryYear;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Gender}, {this.Department}, {this.EntryYear}, {this.Salary}";
        }
        public static string GetDepartmentFromUser()
        {
            Console.WriteLine("Adja meg a részleg nevét:");
            string department = Console.ReadLine();
            return department;
        }
        public static Employee GetHighestPaidEmployee(List<Employee> employees, string department)
        {
            Employee highestPaidEmployee = null;
            foreach (Employee employee in employees)
            {
                if (employee.Department == department && (highestPaidEmployee == null || employee.Salary > highestPaidEmployee.Salary))
                {
                    highestPaidEmployee = employee;
                }
            }

            return highestPaidEmployee;
        }

    }
}
