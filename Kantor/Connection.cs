using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kantor
{
    class Connection
    {
        private string url;

        public Connection()
        {
            // default link to nbp
            this.url = "http://www.nbp.pl/kursy/xml/lasta.xml";
        }
        public Connection(string url) => this.url = url;

        public string getUrl() => this.url;


    }
}
