using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRK.Library
{
    public interface IFileService
    {
        string[] ReadInput(string filePath);
        void WriteOutput(string filePath, string content);
    }
}
