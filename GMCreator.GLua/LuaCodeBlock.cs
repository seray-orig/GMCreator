using System.Text;

namespace GMCreator.GLua;

public struct LuaCodeBlock
{
    public string Header { get; private set; }
    public string Code { get; private set; } = String.Empty;
    public string Ending { get; private set; }

    public LuaCodeBlock(LuaCodeBlock block, string header = "", string ending = "end")
    {
        Header = header;
        Code = block.ToString();
        Ending =  ending;
    }

    public LuaCodeBlock(string code, string header = "", string ending = "end")
    {
        Header = header;
        Code = code;
        Ending =  ending;
    }
    
    public override string ToString()
    {
        if(Header == String.Empty)
            return Code;

        var tempString = new StringBuilder(Code.Length);
        tempString.Append($"{Header}\n");
        foreach(var line in Code.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
            tempString.Append($"\t{line}\n");
        tempString.Append(Ending);

        return tempString.ToString();
    }
}