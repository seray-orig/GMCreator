using GMCreator.GLua;

namespace GMCreator.GLua.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var code = """
                   print('Hello World!')
                   print('and')
                   print('I Love You!!!')
                   """;
        
        var block = new LuaCodeBlock(code, "if (x == 10) then");

        Console.WriteLine(block.ToString());
    }
}
