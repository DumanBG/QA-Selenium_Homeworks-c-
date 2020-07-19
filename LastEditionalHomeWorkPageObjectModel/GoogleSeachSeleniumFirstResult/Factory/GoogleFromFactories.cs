using GoogleSeachFirstResult.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSeachFirstResult.Factory
{
    public static class GoogleFromFactories
    {
        public static GoogleFromModel Create()
        {
            return new GoogleFromModel
            {
                SearchWord = "Selenium"
            };


        }
    }
}
