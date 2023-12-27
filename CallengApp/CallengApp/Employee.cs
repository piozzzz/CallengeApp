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
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }

        public void AddGrade(long grade)
        {
            float valueInFloat = (long)grade;
            this.AddGrade(valueInFloat);
        }

        public void AddGrade(ulong grade)
        {
            float valueInFloat = (ulong)grade;
            this.AddGrade(valueInFloat);
        }

        public void AddGrade(int grade)
        {
            float valueInFloat = (int)grade;
            this.AddGrade(valueInFloat);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float valueInFloat))
            {
                this.AddGrade(valueInFloat);
            }
            else
            {
                Console.WriteLine($"podano nieprawidłową wartosc - tekst: {grade}");
            }
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float valueInFloat))
            {
                this.AddGrade(valueInFloat);
            }
            else
            {
               Console.WriteLine($"podano nieprawidłową wartosc - znak: {grade}");
            }
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
