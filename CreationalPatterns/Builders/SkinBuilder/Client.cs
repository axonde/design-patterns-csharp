namespace CreationalPatterns.Builders.SkinBuilder;

public class Client
{
    static public void Main()
    {
        IBuilder builder = new AsianSkinBuilder();
        Director.BuildGigachad(builder);
        Skin skin = builder.Build();
    }
}
