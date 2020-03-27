namespace Kantor
{
    public class Currency
    {
        private string name { set; get; }
        private string code { get; set; }
        private double value { get; set; }
        private double factor { get; set; }

        public Currency()
        {
            this.name = "-";
            this.code = "-";
            this.value = 0.0;
            this.factor = 1.0;
        }

        public Currency(string name, string code, double value, double factor)
        {
            this.name = name;
            this.code = code;
            this.value = value;
            this.factor = factor;
        }
        public void SetName(string name) => this.name = name;
        public void SetCode(string code) => this.code = code;
        public void SetValue(double value) => this.value = value;
        public void SetFactor(double factor) => this.factor = factor;

        public string GetName() => this.name;
        public string GetCode() => this.code;
        public double GetValue() => this.value;
        public double GetFactor() => this.factor;



    }
}
