namespace CallengApp
{
    public class Employee
    {     
        public string Name { get; private set; }

        public string Surname { get; private set; }


        private List<float> grades = new List<float>();

                
        public Employee(string name, string surname)
        {
            this.Name = name;

            this.Surname = surname;
        }

        
        public void GetListOfGrades()
        {                    
            foreach(var grade in grades)
            {
                Console.WriteLine(Math.Round(grade,2));
            }            
        }
                     
        //--------------------------------------
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
            else
            {
                Console.WriteLine($"podano nieprawidłową wartosc - tekst: {grade}");
            }
        }

        public void AddGrade(char grade)
        {
            Console.WriteLine($"podano nieprawidłową wartosc - znak: {grade}");
        }

        //-------------------------------------------------
        public Statistics GetStatistics()
        {            
            var statis = new Statistics();          

            statis.SumAddedGrades = this.grades.Sum();
            statis.CountGrads = this.grades.Count();


            statis.Average = 0;               
            statis.Max = float.MinValue;      
            statis.Min = float.MaxValue;      


            foreach (var grade in this.grades)               
            {
                statis.Max = Math.Max(statis.Max, grade);    
                statis.Min = Math.Min(statis.Min, grade);    

                statis.Average += grade;                     
            }

            statis.Average /= this.grades.Count;     
            
            return statis;                                          
        }
    }
}
