namespace CallengApp
{
    public class Employee
    {   //=================================================================================================================
        // pola

        public string Name { get; private set; }

        public string Surname { get; private set; }


        private List<float> grades = new List<float>();     // lista zbierajaca oceny - punkty



        //==================================================================================================================

        // konstruktor  - z takimi dwoma parametrami zbuduje sie obiekt        
        public Employee(string name, string surname)
        {
            this.Name = name;

            this.Surname = surname;
        }

        //==================================================================================================================

        public void GetListOfGrades()
        {                    
            foreach(var grade in grades)
            {
                Console.WriteLine(Math.Round(grade,2));
            }            
        }

        //******************************************************************************************
        
        // metoda dodajaca oceny do listy grade
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
               this.grades.Add(grade);
            }
            else
            {
               Console.WriteLine($"podana wartsc przekracza dopuszczalny zakres ( 0 do 100 ): {grade}");
            }

        }

        public void AddGrade(double grade)
        {
            float valueInfloat = (float)grade;
            this.AddGrade(valueInfloat);
        }

        public void AddGrade(long grade)
        {
            float valueInfloat = (long)grade;
            this.AddGrade(valueInfloat);
        }

        public void AddGrade(ulong grade)
        {
            float valueInfloat = (ulong)grade;
            this.AddGrade(valueInfloat);
        }

        public void AddGrade(int grade)
        {
            float valueInfloat = (int)grade;
            this.AddGrade(valueInfloat);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float valueInfloat))
            {
                this.AddGrade(valueInfloat);
            }
            else if (char.TryParse(grade, out char result))    // nie wiem dlaczego zamiana z char `7` -> to 55
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"podano nieprawidłową wartosc - tekst: {grade}");
            }
        }

        //public void AddGrades(char grade)      - inne sposób zamiany
        //{
        //    string tekst = grade.ToString();
        //    this.AddGrade(tekst);
        //}


        //public void AddGrade(char grade) - nie da se przekonwertowac z char na liczbe za pomoca Parse i Try.Parse
        

        // ***************************************************************************************************************
        // metoda która dostanie sie do pliku klasy Statistics, uwaga typem jest Statistics czyli klasa Statistics 
        public Statistics GetStatistics()
        {
            //Statistics statis = new Statistics();      - to pełene zapis
            var statis = new Statistics();            // - to skrocony zapis -> tu nastepuje utworzenie obiektu statis typu Statistics aby korzystac z pol i metod classy Statistics


            statis.SumAddedGrades = this.grades.Sum();
            statis.CountGrads = this.grades.Count();


            statis.Average = 0;               // sztuczka programisty
            statis.Max = float.MinValue;      // sztuczka programisty
            statis.Min = float.MaxValue;      // sztuczka programisty


            foreach (var grade in this.grades)               // petla wyszukujaca Min, Max, Avarage
            {
                statis.Max = Math.Max(statis.Max, grade);    // z dwóch wartosci wybrana zostanie max. warosc
                statis.Min = Math.Min(statis.Min, grade);    // z dwóch wartosci wybrana zostanie min. warosc

                statis.Average += grade;                     // sztuczka zliczajaca Average - srednia
            }

            statis.Average /= this.grades.Count;     // wyliczenie sredniej
            
            return statis;                                           // zwrócenie obiektu statis z wyliczonymi Min Max Average
        }
    }
}
