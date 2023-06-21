using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    
    private ParticleSystem splashEffect;

    private void Start()
    {
        splashEffect = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("COLISION: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Water")
        {
            splashEffect.Play();
        }

        if (collision.gameObject.tag == "Ship")
        {
            Destroy(gameObject);
        }
    }
}
