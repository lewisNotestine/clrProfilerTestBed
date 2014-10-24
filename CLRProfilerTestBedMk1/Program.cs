using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRProfilerTestBedMk1
{
    class Program
    {
        private const int LOOPS = 20;

        static void Main(string[] args)
        {
            var processor = new RequestProcessor();
            var requester = new Requester();

            for (int i = 0; i < LOOPS; i++)
            {
                processor.ProcessRequestResult(requester.GetRequestResult());
            }
        }
    }
}
