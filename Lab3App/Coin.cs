using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        int Value;

        public Coin(string description, int score, int value)
        {
            this.Description = description;
            this.Score = score;
            this.Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += this.Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> treasure)
        {
            base.AddMe(treasure);
            this.UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed");
        }


    }
}
