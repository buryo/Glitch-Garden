using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject shootPosition = default;
    [SerializeField] GameObject zucchinni = default;

    public void Fire()
    {
        GameObject projectile = Instantiate(this.zucchinni, shootPosition.transform.position, transform.rotation);
    }
}
