using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_3__Q3
{
    class MealCard
    {
        //Q # 3
        public int balance;
        public string studentName;
        public MealCard(string name, int initialBalance = 100)
        {
            studentName = name;
            balance = initialBalance;
        }
        public void AddPoints(int points)
        {
            if (points > 0)
            {
                balance += points;
                Console.WriteLine($"{points} points added. New balance: {balance}.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }
        public void PurchaseFood(int points)
        {
            if (points > 0 && balance >= points)
            {
                balance -= points;
                Console.WriteLine($"Food purchased for {points} points. Remaining balance: {balance}.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount. Purchase denied.");
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine($"{studentName}'s Meal Card Balance: {balance} points.");
        }
    }
    class Mealcard
    {
        static void Main(string[] args)
        {
            MealCard student1 = new MealCard("Ali");
            student1.CheckBalance();
            student1.PurchaseFood(30);
            student1.CheckBalance();
            student1.AddPoints(50);
            student1.CheckBalance();
            student1.PurchaseFood(150); 
        }
    }
}
