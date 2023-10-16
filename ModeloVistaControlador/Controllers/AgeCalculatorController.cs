using ModeloVistaControlador.Models;
using System;


namespace ModeloVistaControlador
{
    public class AgeCalculatorController
    {
        private AgeCalculatorView ageCalculatorView;

        public AgeCalculatorController()
        {
            ageCalculatorView = new AgeCalculatorView();
        }

        public void CalculateAgeMainMenu(UserModel personModel)
        {
            if (personModel.BirthDate == System.DateTime.MinValue)
            {
                personModel.BirthDate = ageCalculatorView.GetBirthDateInput();
            }

            int option;
            do
            {
                option = ageCalculatorView.ShowMainMenuAndGetChoice();
                switch (option)
                {
                    case 1://Calculadora de edad
                        CalculateAgeMenu(personModel);
                        break;
                    case 2://Calculadora de edad en otroso planetas
                        ageCalculatorView.CalculateAgeOnOtherPlanets(personModel);
                        break;
                    case 3: //Cambiar Fecha de nacimiento
                        personModel.BirthDate = ageCalculatorView.GetBirthDateInput();
                        break;

                }

            } while (option != 4);

        }

        public void CalculateAgeMenu(UserModel personModel)
        {
            AgeModel age = new AgeModel();

            int option;
            do
            {
                option = ageCalculatorView.ShowMenuCalculateAgeAndGetChoice();
                switch (option)
                {
                    case 1:
                        age.years = personModel.CalculateAgeInYears();
                        ageCalculatorView.ShowAge(age);
                        break;
                    case 2:
                        age = personModel.CalculateAgeInYearsMonthsDays();
                        ageCalculatorView.ShowAge(age);
                        break;
                }
                
            } while (option == 3);
            
        }

    }
}
