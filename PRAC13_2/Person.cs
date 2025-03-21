using System;

namespace PRAC13_2
{
    public class Person
    {
        private string name1;
        private string name2;

        public string FirstName
        {
            get { return name1; }
            set { name1 = value; }
        }

        public string LastName
        {
            get { return name2; }
            set { name2 = value; }
        }

        // вычисления возраста
        public int Age(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;

            // Проверка на день рождения в этом году
            if (birthday.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}