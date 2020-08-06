using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject zucchinni, shootPosition = default;

    public void Fire()
    {
        GameObject projectile = Instantiate(this.zucchinni, shootPosition.transform.position, transform.rotation);
    }
}
