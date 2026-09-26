namespace Free.Scripts;

public class PathHelper
{
    public static string FindPath(string fileName)
    {
        if (File.Exists(fileName))
        {
            return fileName;
        }

        return Path.Combine(AppContext.BaseDirectory, fileName);
    }

    public static string GetReadmePath(string fileName)
    {
        var path = AppContext.BaseDirectory;
        while (!Directory.GetDirectories(path).Any(x=>x.Contains(".git")))
        {
            path = Path.GetDirectoryName(path)!;
        }

        return Path.Combine(path, fileName);
    }
}
