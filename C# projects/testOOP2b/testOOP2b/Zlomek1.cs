using System;

public class Zlomek1
{
    private float citatel;
    private float jmenovatel;

    public Zlomek1()
    {

    }
    public Zlomek1(float citatel1, float jmenovatel1)
    {
        citatel1 = this.citatel;
        jmenovatel1 = this.jmenovatel;
    }

    public float citatel1
    {
        get
        { return citatel; }

        set
        { citatel = value; }
    }
    public float jmenovatel1
    {
        get
        { return jmenovatel; }

        set
        { jmenovatel = value; }
    }
    public float zlomek()
    {
        return citatel / jmenovatel;
    }
}
