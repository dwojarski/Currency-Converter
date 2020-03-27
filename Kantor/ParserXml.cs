using System;
using System.Xml;

namespace Kantor
{
    public class ParserXml : IParser
    {
        private XmlTextReader reader;

        public ParserXml(string url) => this.reader = new XmlTextReader(url);
        public Repository Parse()
        {
            int line = -2;
            string name = "-", code = "-";
            double factor = 0.0, value = 0.0;
            Repository rep = new Repository();
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    line++;
                    switch (line)
                    {
                        case 1:
                            name = reader.Value;
                            break;
                        case 2:
                            factor = Convert.ToDouble(reader.Value);
                            break;
                        case 3:
                            code = reader.Value;
                            break;
                        case 4:
                            value = Convert.ToDouble(reader.Value);
                            line = 0;
                            Currency curr = new Currency(name, code, value, factor);
                            rep.AddCurrency(curr);
                            break;
                    }
                }
            }
            Currency pln = new Currency("złoty", "PLN", 1.0, 1.0);
            rep.AddCurrency(pln);
            return rep;
        }
    }
}
