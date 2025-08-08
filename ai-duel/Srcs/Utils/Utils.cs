namespace ai_duel.Srcs.Utils;

public static class AiDuelUtils
{
    public static void CreateFolder(string path)
    {
        if (Directory.Exists(path))
        {
            Directory.Delete(path, recursive: true);
        }
        Directory.CreateDirectory(path);
    }
}