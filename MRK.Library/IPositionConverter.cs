using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRK.Library
{
    public interface IPositionConverter
    {
        (int, int) Convert(string position);
    }
}
