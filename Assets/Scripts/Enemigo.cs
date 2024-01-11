using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    int destruccion = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D bala)
    {
        if (bala.CompareTag("Bala"))
        {
            destruccion++;
            FindObjectOfType<Juego>()?.EnemigoDestruido();
            Destroy(bala.gameObject);
            Destroy(gameObject);
            Debug.Log("prefab colision");
        }
    }
}
