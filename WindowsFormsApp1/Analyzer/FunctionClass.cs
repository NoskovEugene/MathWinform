using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolishNotation;
using Calculator;

namespace Analyzer
{
    [Serializable]
    public class Function
    {
        public string Fs { get; private set; } = "";

        public List<IElement> F { get; private set; } = new List<IElement>();

        public List<IElement> ReverceNotation { get; private set; } = new List<IElement>();

        Calculator.Calculator calculator = new Calculator.Calculator();

        public bool Calculated { get; set; } = false;

        public Function(string Input)
        {
            Fs = Input;
        }
        
        public void ConvertToList()
        {
            this.F = new Analyzer._Analyzer().Analyze(Fs);
        }
    
        public void GetNotation()
        {
            if(this.F != null)
            {
                ReverceNotation = new RevercePolishNotation().GetNotation(this.F);
            }
        }

        public string Tostring()
        {
            string R = "";
            foreach(IElement item in F)
            {
                R += $"{item.Tostring()} ";
            }
            return R;
        }
        
        public string PolNotTostring()
        {
            string R = "";
            foreach (IElement item in ReverceNotation)
            {
                R += $"{item.Tostring()} ";
            }
            return R;
        }

        public double TryCalculate(double X)
        {
            if (this.Calculated)
                return calculator.Calc(ReverceNotation,X);
            double tmp = calculator.Calc(ReverceNotation, X);
            this.Calculated = true;
            return tmp;
        }
    }
}
