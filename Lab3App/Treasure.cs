using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score;

        public override void AddMe(List<Collectable> treasure)
        {
            base.AddMe(treasure);
            this.UpdateTotalScore();
        }

        public void UpdateTotalScore()
        {
            Board.TotalScore += this.Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }
    }
}
