using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Models
{
    public class GameModel : ObservableObject
    {
        private string name;

        public String Name
        {
            get => name;
            set => base.SetProperty(ref name, value);
        }

        private string platform;

        public String Platform
        {
            get => platform;
            set => base.SetProperty(ref platform, value);
        }
    }
}