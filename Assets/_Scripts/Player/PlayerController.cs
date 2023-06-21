using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager manager;
    [SerializeField] Shooting shooting;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
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
