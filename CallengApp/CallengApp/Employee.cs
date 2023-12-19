namespace CallengApp
{
    public class Employee
    {   //*****************************************************************************************************************
        // pola

        public string Name { get; private set; }

        public string Surname { get; private set; }


        private List<float> grades = new List<float>();     // lista zbierajaca oceny - punkty


        public float getSumaGrades      // zmienna podajaca sumie z punktow - tzw. Full Property
        {
            get
            {
                return this.grades.Sum();
            }
        }


        public float getLiczbaGrades    // zmienna podajaca liczbe-ilosc punktow - tzw. Full Property
        {
            get
            {
                return this.grades.Count();
            }
        }

        //*****************************************************************************************************************

        // konstruktor  - z takimi dwoma parametrami zbuduje sie obiekt        
        public Employee(string _name, string _surname)
        {
            this.Name = _name;

            this.Surname = _surname;
        }

        //*****************************************************************************************************************

        // metoda dodajaca oceny do listy grade
        public void AddGrades(float _grade)
        {
            this.grades.Add(_grade);
        }


        // metoda która dostanie sie do pliku klasy Statistics, uwaga typem jest Statistics czyli klasa Statistics 
        public Statistics GetStatistics()
        {
            //Statistics statis = new Statistics();      - to pełene zapis
            var statis = new Statistics();            // - to skrocony zapis -> tu nastepuje utworzenie obiektu statis typu Statistics aby korzystac z pol i metod classy Statistics

            statis.Average = 0;               // sztuczka programisty
            statis.Max = float.MinValue;      // sztuczka programisty
            statis.Min = float.MaxValue;      // sztuczka programisty


            foreach (var licznikgrade in this.grades)               // petla wyszukujaca Min, Max, Avarage
            {
                statis.Max = Math.Max(statis.Max, licznikgrade);    // z dwóch wartosci wybrana zostanie max. warosc
                statis.Min = Math.Min(statis.Min, licznikgrade);    // z dwóch wartosci wybrana zostanie min. warosc

                statis.Average += licznikgrade;                     // sztuczka zliczajaca Average - srednia
            }

            statis.Average = statis.Average / this.grades.Count;     // wyliczenie sredniej

            return statis;                                           // zwrócenie obiektu statis z wyliczonymi Min Max Average
        }
    }
}
