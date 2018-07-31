using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyricScope.Provider;

namespace LyricScope.Services.Lyrics
{
    public interface IVisitable
    {
       string AcceptVisitor(ILyricsVisitor visitor);
    }
}
