namespace MyFirstApi.Entities;

public abstract class Device
{
    public bool IsConnected() => true;
    public abstract string GetBrand();
    public virtual string Hello()
    {
        return "Hello";
    }
}
