using UnityEngine;

public class Trophy : Defender
{
    private int starGains = 25;

    public int StarGains
    {
        get { return starGains; }
        private set
        {
            if (value >= 0)
                starGains = value;
        }
    }

    protected void GainStar(int starToAdd)
    {
        StarController.AddStar(starToAdd);
    }
}