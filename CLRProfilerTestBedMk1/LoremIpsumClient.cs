using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CLRProfilerTestBedMk1
{
    class LoremIpsumClient
    {
        public static LoremIpsumClient Get()
        {
            return new LoremIpsumClient();
        }

        public string GetRequestData()
        {
            var sURL = "http://loripsum.net/api";
            WebRequest wrGETURL = WebRequest.Create(requestUriString: sURL);

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            return objReader.ReadToEnd();
        }
    }
}
