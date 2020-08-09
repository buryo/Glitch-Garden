using System;
using UnityEngine;

public static class StarController
{
    public static int Stars { get; set; } = 100;
    public static event Action<int> OnStarChanged;

    public static void AddStar(int starAmount)
    {
        Stars += starAmount;
        OnStarChanged?.Invoke(Stars);
    }

    public static bool BuyIfEnoughStars(int defenderPrice)
    {
        if (Stars >= defenderPrice)
        {
            Stars -= defenderPrice;
            OnStarChanged?.Invoke(Stars);
            return true;
        }
        Debug.Log("Not enough stars!");
        return false;
    }
}
