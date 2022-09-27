﻿
using System.Collections.ObjectModel;

namespace WPFMVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Header = "MVVM";
            costumers = new ObservableCollection<Costumer>();
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
            costumers.Add(new Costumer { Name = "hoi", Age = 10, CostumerId = Guid.NewGuid().ToString() });
        

        }

        [ObservableProperty]
        ObservableCollection<Costumer> costumers;

        [ObservableProperty]
        string header;

        [ICommand]
        void AddCostumer()
        {
            var window = new CostumerWindow();
            window.DataContext = new CostumerViewModel();
            window.ShowDialog();
        }
    }
   
}
