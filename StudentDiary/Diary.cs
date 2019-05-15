using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        List<float> grades;



        public void AddGrade(float grade)
        {
            grades.Add(grade);

        }
        public float Average()
        {
            float suma = 0, avg = 0;
            foreach (var grade in grades)
            {
                suma += grade;

            }
            avg = suma / grades.Count;
            return avg;
        }
        public float MaxGrade()
        {
            return grades.Max();
        }
        public float MinGrade()
        {
            return grades.Min();

        }

    }
}
