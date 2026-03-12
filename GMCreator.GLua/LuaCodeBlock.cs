using System.Text;

namespace GMCreator.GLua;

public class LuaCodeBlock(string countour, string filler)
{
    public string Сontour = countour;
    public string Filler = filler;
    
    public override string ToString()
    {
        var tempString = new StringBuilder(Code.Length);
        tempString.Append($"{Header}\n");
        foreach(var line in Code.Split([ "\r\n", "\r", "\n" ], StringSplitOptions.None))
            tempString.Append($"\t{line}\n");
        tempString.Append(Ending);

        return tempString.ToString();
    }
}