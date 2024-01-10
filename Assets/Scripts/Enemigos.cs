using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float velocidad = 1.0f;

    void Start()
    {
        InvokeRepeating("SpawnearPrefab", 0f, 2f);
    }

    void Update()
    {
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag("Enemigo");
        foreach (GameObject obj in prefabs)
        {
            obj.transform.position += Vector3.down * velocidad * Time.deltaTime;
            if (obj.transform.position.y < -10f)
            {
                Destroy(obj);
                Debug.Log("prefab destruido");
            }
            
        }
    }

    void SpawnearPrefab()
    {
        var position = new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(0f, 6.0f), 0);
        Instantiate(enemigoPrefab, position, Quaternion.identity);
        Debug.Log("prefab instanciado");
    }

}


