namespace wc_sharp.ProgramLogic;

public interface ILogic
{
    Task CharCount(string file);
    Task LineCount(string file);
    Task WordCount(string file);
}

public class Logic : ILogic
{
    public async Task CharCount(string file)
    {
        var fileContent = await File.ReadAllTextAsync(file);
        Console.WriteLine($"Number of characters in file: {fileContent.Length}");
    }
    
    public async Task LineCount(string file)
    {
        var fileContent = await File.ReadAllLinesAsync(file);
        Console.WriteLine($"Number of lines in file: {fileContent.Length}");
    }
    
    public async Task WordCount(string file)
    {
        var fileContent = await File.ReadAllTextAsync(file);
        var words = fileContent.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Number of words in file: {words.Length}");
    }
}

