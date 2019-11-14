using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodavimoTeorijaA15.Channel
{
    interface IChannel
    {
        string AddNoise(string text);
        void SetNoiseLevel(double percentage);
    }
}
