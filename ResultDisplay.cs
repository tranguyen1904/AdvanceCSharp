using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class ResultDisplay
    {
        public void Subscribe(MainProcess mainProcess)
        {
            mainProcess.ProcessCompleted += Display;
        }

        public void Display(object sender, ProcessEventArgs e)
        {
            if (sender == null)
            {
                Console.WriteLine("No New Product Added.");
                return;
            }
            Console.WriteLine("A New Prodct Added.");
        }

        public void UnSubscribe(MainProcess mainProcess)
        {
            mainProcess.ProcessCompleted -= Display;
        }
    }
}
