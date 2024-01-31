﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool : Collectable
    {
        public virtual void DoAction()
        {

        }

        public override void AddMe(List<Collectable> tool)
        {
            base.AddMe(tool);
            this.DoAction();
        }
    }
}
