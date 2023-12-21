namespace CallengApp.Tests
{
    // Test majacy sprawdzic poprawne dzi³anie metody GetStatistics() z klasy Employee
    // Test ten na razie (nie zawiera rzeczy) nie sprawdza poprawnosci podanych - wprowadzonych danych - czyli walidacja danych
   
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectMinValue()
        {
            //arange
            var employee = new Employee("piotr", "zzz");

            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(6);

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

            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(6);

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

            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(6);

            //act
            var stat = employee.GetStatistics();

            //asert
            Assert.AreEqual(Math.Round(3.67, 2), Math.Round(stat.Average, 2));   
                                                          
        }
    }
}