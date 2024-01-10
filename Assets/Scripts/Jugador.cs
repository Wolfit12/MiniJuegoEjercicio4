using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameObject balaPrefab;
    public GameObject jugador;
    public int vidas = 0;
    float velocidad = 5.0f;
    float velocidadBalas = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento jugador
        float h = 0f;
        float v = 0f;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            v += 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            v -= 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            h -= 1f;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))  
        {
            h += 1f;
        }
        jugador.transform.position = transform.position + new Vector3(h * velocidad * Time.deltaTime, v * velocidad * Time.deltaTime, 0);

        //Lanzar balas
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Lanzabalas();
        }

        //Comprobar posicion balas + tiempo
        GameObject[] balaPrefabs = GameObject.FindGameObjectsWithTag("Bala");
        foreach (GameObject obj in balaPrefabs)
        {
            obj.transform.position += Vector3.up * velocidadBalas * Time.deltaTime;

            //El prefab se destruye al salir de la pantalla o a los 3 segundos
            if (obj.transform.position.y > 6f)
            {
                Destroy(obj);
                Debug.Log("enemigo destruido");
            }
            else
            {
                int destroyDelay = 3;
                Destroy(obj, destroyDelay);
            }

        }

    }

    //Prefab Lanzar balas
    void Lanzabalas()
    {
        var balaPosicion = jugador.transform.position;
        Instantiate(balaPrefab, balaPosicion, Quaternion.identity);
        Debug.Log("enemigo instanciado");
    }
}
