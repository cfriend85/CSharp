using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool isFull()
        {
            return calorieIntake > 1200 ? true : false;
        }

        public void Eat(Food item)
        {
            if(isFull()){
                Console.WriteLine("Ninja fucking full");
            }
            else{
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"{item.Name}, {item.isSpicy}, {item.isSweet}");
            }
        }
    }
}