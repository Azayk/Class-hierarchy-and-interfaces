using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5C_2._0
{
    public interface ICalculate
    {
        void Plus(int value);
        void Minus(int value);
    }

    public interface IVisual
    {
        string Name { get; set; }
        void DrawObject();
    }
}
