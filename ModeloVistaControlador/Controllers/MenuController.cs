using ModeloVistaControlador.Views;


namespace ModeloVistaControlador.Controllers
{
    class MenuController
    {
        private UserModel personModel;
        private MenuView menuView;

        public MenuController()
        {
            personModel = new UserModel();
            menuView = new MenuView();
        }

        public void ManageMenu()
        {
            menuView.ShowWelCome();

            GetName();

            int option;
            do
            {
                option = menuView.ShowMenuAndGetChoice(personModel.Name);
                switch (option)
                {
                    case 1:
                        AgeCalculatorController ageCalculatorController = new AgeCalculatorController();
                        ageCalculatorController.CalculateAgeMainMenu(personModel);
                        break;
                    case 2:
                        GetName();
                        break;
                }

            } while (option != 3);

            menuView.ShowDespedida(personModel.Name);

        }

        private void GetName()
        {
            personModel.Name = menuView.GetNameInput();
            menuView.ShowName(personModel.Name);
        }
    }
}
