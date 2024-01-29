using Cocona;
using wc_sharp.ProgramLogic;

namespace wc_sharp;

public class ProgramCommands
{
    private readonly ILogic _logic;
    
    public ProgramCommands(ILogic logic)
    {
        _logic = logic;
    }
    
    [Command("chars", Description = "Count characters")]
    public async Task CharCount(string file)
    { 
        await _logic.CharCount(file);
    }
    [Command("lines", Description = "Count lines")]
    public async Task LineCount(string file)
    {
        await _logic.LineCount(file);
    }
    [Command("words", Description = "Count words")]
    public async Task WordCount(string file)
    {
        await _logic.WordCount(file);
    }
    
    [Command("all", Description = "Count all")]
    public async Task All(string file)
    {
        await _logic.CharCount(file);
        await _logic.LineCount(file);
        await _logic.WordCount(file);
    }
}