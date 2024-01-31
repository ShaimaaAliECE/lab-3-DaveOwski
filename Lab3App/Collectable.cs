using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable 
    {
        public string Description;

        public CollectionBoard Board = new CollectionBoard();

        public virtual void AddMe(List<Collectable> collectable)
        {
            collectable.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
        }

        public virtual void Display()
        {
            throw new NotImplementedException();
        }

        
        //Collectable is an abstract class?

    }
}
