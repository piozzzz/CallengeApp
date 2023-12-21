using CallengApp;

var employee = new Employee("piotr", "zzz");      // tu nastepuje utworzenie obiektu typu employee aby korzystac z pol i metod classy Employee

//employee.AddGrade(2);                             // wywolanie metody dodajacej punkty
//employee.AddGrade(3);
//employee.AddGrade(6);
//employee.AddGrade("6");
//employee.AddGrade(22);
//employee.AddGrade("22");
//employee.AddGrade(666);
//employee.AddGrade("666");
//employee.AddGrade("piotr");
//employee.AddGrade(9.66);
//employee.AddGrade(9.33333333333);
//employee.AddGrade(9.88888888888);
employee.AddGrade('7');


var sta = employee.GetStatistics();                         // tworzymy "zmienna sta" i do niej przypisujemy "metode" dzieki której dostaniemy sie do "zmiennych Min  Max Average"

Console.WriteLine();
Console.WriteLine($"Liczba dodanych punktow: {sta.CountGrads}");
Console.WriteLine("Lista dodanych punktow:");
employee.GetListOfGrades();
Console.WriteLine($"**{sta.SumAddedGrades:N2}** - suma dodanych punktow");

Console.WriteLine();
Console.WriteLine($"wartosc minimalna: {sta.Min:N2}");
Console.WriteLine($"wartosc maksymalan: {sta.Max:N2}");
Console.WriteLine($"wartosc srednia: {sta.Average:N2}");   


