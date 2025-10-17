namespace CreationalPatterns.Builders.SkinBuilder;

public class Director()
{
    static public void BuildNPC(IBuilder builder)
    {
        builder.SetHairSize(100);
        builder.SetBodyColor("white");
        builder.SetBodyType("fat");
    }

    static public void BuildGigachad(IBuilder builder)
    {
        builder.SetHairSize(1);
        builder.SetBodyColor("grey");
        builder.SetBodyType("gigachad");
    }
}
