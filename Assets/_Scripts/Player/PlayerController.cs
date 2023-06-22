using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource cannon_sfx;
    public ParticleSystem smoke_vfx;
    public GameManager manager;
    [SerializeField] Shooting shooting;
    public float cooldown;
    private float nextFireTime;

    void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
                nextFireTime = Time.time + cooldown;
            }
        }
    }

    void Shoot()
    {
        cannon_sfx.Play();
        smoke_vfx.Play();
        shooting.Shoot();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Cannonball")
        {
            manager.RecibirImpacto();
        }
    }
}
