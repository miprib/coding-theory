using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodavimoTeorijaA15.Encoding
{
    interface IEncoder
    {
        string Encode(string text);
        void EnableDebug(bool state);
    }
}
