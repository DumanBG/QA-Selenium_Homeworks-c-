using AutomationPracticePageObject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticePageObject.Factories
{
    public static class AutomationPracticeFactories
    {
        public static AutomationPracticeFromModel Create()
        {
            return new AutomationPracticeFromModel
            {
                Email = "dumanTester@abv.bg",
                FirstNamePanel = "Duman",
                LastNamePanel = "Tester",
                PasswordPanel = "dumanDuman",
                AddressPanel = "Main str",
                CityPanel = "Alabama",
                IdStatePanel = "Alabama",
                PhoneMobile = "1234567890",
                PosteCodePanel = "12345"


            };


        }
    }
}
