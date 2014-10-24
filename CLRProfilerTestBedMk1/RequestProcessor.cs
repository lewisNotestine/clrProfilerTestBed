using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRProfilerTestBedMk1
{
    class RequestProcessor
    {
        /// <summary>
        /// This is intentionally obscuring/making redundant the data from the parameter.
        /// </summary>
        /// <param name="requestResult"></param>
        public void ProcessRequestResult(string requestResult)
        {
            var result = LoremIpsumClient.Get().GetRequestData(); // this is the bug.

            Console.WriteLine(requestResult);
        }
    }
}
