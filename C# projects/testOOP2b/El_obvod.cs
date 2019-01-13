using System;

public class El_obvod
{
    private float proud, napeti;
    
    public El_obvod()
	{
    
	}

    public El_obvod(float proud, float odpor)
    {
        Proud = proud;
        Napeti = napeti;
    }

    public static float Napeti
    {
        get
        { return napeti; }

        set
        { napeti=value; }
    }
    public static float Proud
    {
        get
        { return proud; }

        set
        { proud=value; }
    }
    public float Odpor(float napeti, float proud)
    {
        return napeti / proud;
    }
}
