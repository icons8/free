namespace Free.Scripts;

public class PathHelper
{
    public static string FindPath(string fileName)
    {
        return File.Exists(fileName)
            ? fileName
            : Path.Combine("bin", "Debug", "net7.0", fileName);
    }
}