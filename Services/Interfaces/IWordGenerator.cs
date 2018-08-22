using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProactiveBot.Services.Interfaces
{
    interface IWordGenerator
    {

        string NewWord();

        List<string> NewWords(int numberOfWords);
    }
}
