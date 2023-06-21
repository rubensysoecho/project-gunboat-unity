
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject cannonBall;
    public Transform firePoint;
    public float force;

    public void Shoot()
    {
        GameObject bullet = Instantiate(cannonBall, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        //rb.AddForce(new Vector3(2 * force, 0), ForceMode.Impulse);
        if (firePoint.gameObject.name == "Cannon")
        {
            rb.velocity = force * firePoint.right;
        }
        else
        {
            rb.velocity = force * -firePoint.right;
        }
        
    }
}
