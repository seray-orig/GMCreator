using System.Text;

namespace GMCreator.GLua;

public class LuaCodeBlock
{
    public string Header = String.Empty;
    public string Code;
    public string Ending = String.Empty;

    public LuaCodeBlock(string code)
    {
        Code = code;
    }

    public LuaCodeBlock(string header, string code, string ending = "end")
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
        foreach(var line in Code.Split([ "\r\n", "\r", "\n" ], StringSplitOptions.None))
            tempString.Append($"\t{line}\n");
        tempString.Append(Ending);

        return tempString.ToString();
    }
}