using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.Services;

namespace WPFMVVM.ViewModels
{
    public partial class CostumerViewModel : ObservableObject
    {
        DatabaseService databaseService;
        public CostumerViewModel(DatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        [ObservableProperty]
        string costumerName;

        [ObservableProperty]
        string age;

        [ICommand]
        void Add(Window win)
        {
            if (int.TryParse(age, out int _age) == false)
                return;

            var newcostumer = new Costumer
            {
                Name = costumerName,
                Age = _age,
                CostumerId = Guid.NewGuid().ToString(),
            };

            MessageBox.Show($"Klant  {newcostumer.Name} aangemaakt");
            win.Close();
        }
    }
}
