//Тема 31. Урок 1. List
//Задача: Учет сотрудников в компании.
//Разработайте программу для учета сотрудников в компании. Каждый
//сотрудник должен иметь имя, фамилию и должность. Реализуйте
//следующие функции:

//Добавление нового сотрудника в список.
//Удаление сотрудника по его фамилии.
//Поиск сотрудника по его имени или должности.
//Вывод списка всех сотрудников.
//Подсчет количества сотрудников в компании

using Theme31Lesson1.List;

Employees employees = new Employees();

do
{
    Console.Clear();
    Console.Write("1 - Добавить сотрудника\n" +
        "2 - Удалить сотрудника по его фамилии\n" +
        "3 - Поиск сотрудника по имени\n" +
        "4 - Поиск сотрудника по должности\n" +
        "5 - Вывод списка сотрудников\n" +
        "6 - Вывод количества сотрудников\n");
    int n;
    Console.Write("выберите действие: ");
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1:
            {
                Console.Write("Введите имя: ");
                string firstName = Console.ReadLine()!;
                Console.Write("Введите фамилию: ");
                string lastName = Console.ReadLine()!;
                Console.Write("Введите должность: ");
                string position = Console.ReadLine()!;
                Employee employee = new Employee(firstName, lastName, position);
                employees.AddEmployee(employee);
            }
            break;
        case 2:
            {
                Console.Write("Введите фамилию: ");
                string lastName = Console.ReadLine()!;
                employees.RemoveEmployee(lastName);
            }
            break;
        case 3:
            {
                Console.Write("Введите имя: ");
                string firstName = Console.ReadLine()!;
                Employee foundEmployee=employees.findByName(firstName);
                if (foundEmployee != null)
                {
                    Console.WriteLine(foundEmployee.getFirstName()+" "+foundEmployee.getLastName()+" "+foundEmployee.getPosition());
                }
                else Console.WriteLine("Сотрудник с таким именем не найден.");
            }
            break;
        case 4: 
            {
                Console.Write("Введите должность: ");
                string position = Console.ReadLine()!;
                Employee foundEmployee = employees.findByPosition(position);
                if (foundEmployee != null)
                {
                    Console.WriteLine(foundEmployee.getFirstName() + " " + foundEmployee.getLastName() + " " + foundEmployee.getPosition());
                }
                else Console.WriteLine("Сотрудник с такой должностью не найден.");
            } break;
        case 5:
            {
                List<Employee> empList = employees.getEmployees();
                foreach(Employee emp in empList)
                {
                    Console.WriteLine(emp.getFirstName() + " " + emp.getLastName() + " " + emp.getPosition());
                }
            }
            break;
        case 6:
            {
                Console.WriteLine("Количество сотроудников: "+employees.getEmployeesCount());
            }
            break;
    }
    Console.ReadKey();
} 
while (true);