using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        private int fitnessProgramId {  get;  set; }
        private string ttitle { get;  }
        private string duration { get;  }

       private string price { get; }
    

        public FitnessProgram(int fitnessProgramId, string ttitle, string duration, string price)
        {
            this.fitnessProgramId = fitnessProgramId;
            this.ttitle = ttitle;
            this.duration = duration;
            this.price = price;
        }

        public override string ToString()
        {
            return $"fitnessProgramId: {FitnessProgramId}, Title: {Title}, Duration: {Duration}, Price: {Price};"
        }
    }
}
