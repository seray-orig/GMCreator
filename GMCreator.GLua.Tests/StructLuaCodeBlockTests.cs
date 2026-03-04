using System.Text;

namespace GMCreator.GLua.Tests;

public class StructLuaCodeBlockTests
{
    [Fact]
    public void OneLineTextTabulationTest()
    {
        // Arrange
        var header = "if (x == 10) then";
        
        var ending = "end";
        
        var inputCode = """
                        print('Hello World!')
                        print('and')
                        print('I Love You!!!')
                        """;

        var expectedCode = new StringBuilder();
        expectedCode.AppendLine(header);
        foreach (var line in inputCode.Split(Environment.NewLine.ToCharArray()))
            expectedCode.AppendLine($"\t{line}");
        expectedCode.Append(ending);
        
        // Act
        var block = new LuaCodeBlock(header, inputCode, ending);
        
        // Assert
        Assert.Equal(expectedCode.ToString(), block.ToString());
    }

    [Fact]
    public void Test2()
    {
        var x = new LuaCodeBlock("print('Hello')");
        Assert.Equal(x.ToString(), "print('Hello')");
    }
    
    #warning Под вопросом. Использовать символ табуляции или пробелы?
    //[Fact]
    public void RawLiteralTextTabulationTest()
    {
        var header = "if (x == 10) then";
        
        var ending = "end";
        
        var inputCode = """
                        print('Hello World!')
                        print('and')
                        print('I Love You!!!')
                        """;

        var expectedCode = """
                           if (x == 10) then
                            print('Hello World!')
                            print('and')
                            print('I Love You!!!')
                           end
                           """;
        
        var block = new LuaCodeBlock(inputCode, header, ending);
        
        Assert.Equal(expectedCode.ToString(), block.ToString());
    }
}
