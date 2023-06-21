using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Advance();
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Backwards();
        }
    }

    void Shoot()
    {
        Debug.Log("Disparo!");
    }

    void Advance()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void Backwards()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
