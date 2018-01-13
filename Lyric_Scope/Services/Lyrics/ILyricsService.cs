using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricScope.Services.Lyrics

{
    public interface ILyricsService
    {
        //bool HasAuth { get; }
        //bool IsAuthRquired { get; }
        //bool SupportsSynscronize { get; }
        //Task<bool> Connect();

        string GetLyrics(string interpret, string track, string album = "");
    }
}
