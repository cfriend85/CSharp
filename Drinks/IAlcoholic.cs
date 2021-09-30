using System;

namespace Drinks
{
    interface IAlcoholic
    {
        double abv {get;set;}
        void addAlcohol(double abv);
    }
}