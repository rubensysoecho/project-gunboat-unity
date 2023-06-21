using UnityEngine;

public class GameManager : MonoBehaviour
{
    static private int maxHP = 5;
    public int hp;

    void Start()
    {
        hp = maxHP;
    }

    void Update()
    {
        
    }

    public void RecibirImpacto()
    {
        if (hp - 1 == 0)
        {
            Hundirse();
        }
        else
        {
            hp--;
        }
    }

    public void Hundirse()
    {
        Debug.Log(gameObject.name.ToUpper() + " DERROTADO");
        Destroy(gameObject);
    }
}
