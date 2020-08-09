using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject shootPosition = default;
    [SerializeField] GameObject ammo = null;
    public int StarCost { get; } = 100;
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

    public void Fire()
    {
        GameObject projectile = Instantiate(ammo, shootPosition.transform.position, transform.rotation);
    }

    public void GainStar()
    {
        StarController.AddStar(starGains);
    }
}
