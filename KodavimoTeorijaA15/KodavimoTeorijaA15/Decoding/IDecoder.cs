using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodavimoTeorijaA15.Decoding
{
    interface IDecoder
    {
        string Decode(string text);
        void EnableDebug(bool state);
    }
}
