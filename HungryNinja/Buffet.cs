using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Buffet
{
    public List<Food> Menu;
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Spaghetti", 297, false, false),
            new Food("Macaroni & Cheese", 210, false, false),
            new Food("Nacho Cheese Doritos", 150, false, false),
            new Food("Chocolate Covered Pretzels", 130, false, true),
            new Food("Pepperoni Pizza", 500, true, false),
            new Food("Ribeye & Garlic Mash", 1100, false, false),
            new Food("Grilled Chicken & Sausage Gumbo", 500, false, false),
        };
    }
    public Food Serve()
    {
        Random meal = new Random();
        return Menu[meal.Next(0, Menu.Count)];
    }
}
}