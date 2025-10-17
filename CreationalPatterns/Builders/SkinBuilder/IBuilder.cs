namespace CreationalPatterns.Builders.SkinBuilder;

public interface IBuilder
{
    public void SetHairSize(int size);
    public void SetBodyColor(string color);
    public void SetBodyType(string type);

    // and million others setters.

    public Skin Build();
}
