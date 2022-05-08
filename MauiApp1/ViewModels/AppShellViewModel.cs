using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
   public partial class AppShellViewModel:ObservableObject
    {

        public string Title { get; set; } = "Hello123";

        public AppShellViewModel()
        {
         
        }

        [ICommand]
        private void CustomerNavigate()
        {
            throw new NotImplementedException();
        }
    }
}
