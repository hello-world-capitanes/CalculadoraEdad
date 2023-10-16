using ModeloVistaControlador.Models;
using System;

namespace ModeloVistaControlador
{
   public class UserModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int CalculateAgeInYears()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;

            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public AgeModel CalculateAgeInYearsMonthsDays()
        {
            DateTime today = DateTime.Today;
            AgeModel age = new AgeModel()
            {
                years = today.Year - BirthDate.Year,
                months = today.Month - BirthDate.Month,
                days = today.Day - BirthDate.Day
            };


            if (age.days < 0)
            {
                age.months--;
                age.days += DateTime.DaysInMonth(today.Year, today.Month);
            }

            if (age.months < 0)
            {
                age.years--;
                age.months += 12;
            }

            return age;
        }
    }
}
