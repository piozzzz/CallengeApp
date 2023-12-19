using CallengApp;


var employee = new Employee("piotr", "zzz");                 // tu nastepuje utworzenie obiektu typu employee aby korzystac z pol i metod classy Employee
employee.AddGrades(2);                                       // uzywamy metody dodajacej punkty
employee.AddGrades(3);
employee.AddGrades(6);



Console.WriteLine($"liczba dodanych punktow: {employee.getLiczbaGrades}");
Console.WriteLine($"suma punktow: {employee.getSumaGrades} ");

var sta = employee.GetStatistics();                         // tworzymy "zmienna stat" i do niej przypisujemy "metode" dzieki której dostaniemy sie do "zmiennych Min  Max Average"
Console.WriteLine("");
Console.WriteLine($"wartosc minimalna: {sta.Min}");
Console.WriteLine($"wartosc maksymalan: {sta.Max}");
Console.WriteLine($"wartosc srednia: {sta.Average:N2}");   // zaokroglenie wartosci do drugiego miejsca po przecinku


