namespace CreationalPatterns.Builders.SkinBuilder;

public class EuropeanSkinBuilder() : IBuilder
{
    private (int HairSize, string BodyColor, string BodyType) _params = (1, "white", "semi-fat");

    public void SetHairSize(int size)
    {
        _params.HairSize = size;
    }
    public void SetBodyColor(string color)
    {
        _params.BodyColor = color;
    }
    public void SetBodyType(string type)
    {
        _params.BodyType = type;
    }

    public Skin Build()
    {
        return new Skin(_params.HairSize, _params.BodyColor, _params.BodyType);
    }
}
