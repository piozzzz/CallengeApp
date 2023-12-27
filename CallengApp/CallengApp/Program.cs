using CallengApp;

var employee = new Employee("piotr", "zzz");     

employee.AddGrade(0);                            
employee.AddGrade(3);
employee.AddGrade(-33);
employee.AddGrade(3.6f);
employee.AddGrade(3.7d);
employee.AddGrade(3.5);
employee.AddGrade(6);
employee.AddGrade("6");
employee.AddGrade(22);
employee.AddGrade("22");
employee.AddGrade(666);
employee.AddGrade("666");
employee.AddGrade("piotr");
employee.AddGrade(9.66);
employee.AddGrade(9.33333333333);
employee.AddGrade(9.88888888888);
employee.AddGrade('7');


var sta = employee.GetStatistics();                    

Console.WriteLine();
Console.WriteLine($"Liczba dodanych punktow: {sta.CountGrads}");
Console.WriteLine("Lista dodanych punktow:");
employee.GetListOfGrades();
Console.WriteLine($"**{sta.SumAddedGrades:N2}** - suma dodanych punktow");

Console.WriteLine();
Console.WriteLine($"wartosc minimalna: {sta.Min:N2}");
Console.WriteLine($"wartosc maksymalan: {sta.Max:N2}");
Console.WriteLine($"wartosc srednia: {sta.Average:N2}");   


