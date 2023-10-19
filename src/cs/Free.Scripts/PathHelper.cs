namespace Free.Scripts;

public class PathHelper
{
    public static string FindPath(string fileName)
    {
        return File.Exists(fileName)
            ? fileName
            : Path.Combine("bin", "Debug", "net7.0", fileName);
    }

    public static string GetReadmePath()
    {
        var path = AppContext.BaseDirectory;
        while (!Directory.GetDirectories(path).Any(x=>x.Contains(".git")))
        {
            path = Path.GetDirectoryName(path)!;
        }

        return Path.Combine(path, "README.md");
    }
}