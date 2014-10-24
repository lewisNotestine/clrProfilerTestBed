using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRProfilerTestBedMk1
{
    class Requester
    {
        private readonly LoremIpsumClient Client = LoremIpsumClient.Get();

        public string GetRequestResult()
        {
            return Client.GetRequestData();
        }
    }
}
