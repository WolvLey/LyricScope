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
