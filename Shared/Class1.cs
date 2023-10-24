namespace Shared;

public class Class1
{
    public Class1(string path)
    {
        _stream = new FileStream(path, FileMode.Create);
    }
    private Stream _stream;
}
