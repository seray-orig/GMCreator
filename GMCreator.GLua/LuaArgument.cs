namespace GMCreator.GLua;

public struct LuaArgument
{
    public string Value;

    public LuaArgument(string value, bool variable)
    {
        if (variable)
            Value = value;
        else
            Value = ;
    }
}
