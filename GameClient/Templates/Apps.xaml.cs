
using System.Windows.Controls;
using Common;

namespace GameClient.Templates
{
    public partial class Apps : UserControl
    {
        private IProjectMeta[] projects = new IProjectMeta[] {
            new Calculator.Project(),
            new CheckersV2.Project(),
            new TicTacToe.Project(),
            new TriviaGame.Project(),
            new CurrencyConverter.Project(),
            new UserManagement.Project()
        };
        public Apps()
        {
            InitializeComponent();
            InitializeProjectButtons();
        }

        private void InitializeProjectButtons()
        {
            int i = 0;

            foreach (var project in projects)
            {
                AppCard appCard = new AppCard(project);
                ProjectsWP.Children.Add(appCard);
            }
        }
    }
}
