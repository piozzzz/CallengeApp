namespace CallengApp.Tests
{
    // Test majacy sprawdzic poprawne dzi³anie metody GetStatistics() z klasy Employee
    // Test ten na razie (nie zawiera rzeczy) nie sprawdza poprawnosci podanych - wprowadzonych danych - czyli walidacja danych
    // nie dzia³ zaokraglenie po przecinku N2 - test nie przechodzi dla Average

    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectMinValue()
        {
            //arange
            var employee = new Employee("piotr", "zzz");

            employee.AddGrades(2);
            employee.AddGrades(3);
            employee.AddGrades(6);

            //act
            var stat = employee.GetStatistics();

            //asert
            Assert.AreEqual(2, stat.Min);
        }


        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectMaxValue()
        {
            //arange
            var employee = new Employee("piotr", "zzz");

            employee.AddGrades(2);
            employee.AddGrades(3);
            employee.AddGrades(6);

            //act
            var stat = employee.GetStatistics();

            //asert
            Assert.AreEqual(6, stat.Max);
        }


        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectAverageValue()
        {
            //arange
            var employee = new Employee("piotr", "zzz");

            employee.AddGrades(2);
            employee.AddGrades(3);
            employee.AddGrades(6);

            //act
            var stat = employee.GetStatistics();

            //asert
            Assert.AreEqual(3.67, stat.Average);   // warunek nie sp³niony bo wartosc Average nie zaokraglona do drugiega miejsca po przecinku
                                                   // nie dzi³a zaokraglenie dla stat.Average:N2 - nie wiem, moze nie mozna uzyc tutaj :N2
        }
    }
}