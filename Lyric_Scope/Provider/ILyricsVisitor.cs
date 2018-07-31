using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyricScope.Services.Lyrics;

namespace LyricScope.Provider
{
    public interface ILyricsVisitor
    {
        string VisitGenius(Genius genius);
    }
}
