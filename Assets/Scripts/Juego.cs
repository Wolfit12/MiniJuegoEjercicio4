using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Juego : MonoBehaviour
{
    public Text tiempo;
    public Text puntos;
    int destruidos = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Reloj();
    }

    void Reloj()
    {
        float hora = Time.time;
        int min = Mathf.FloorToInt(hora / 60f);
        int seg = Mathf.FloorToInt(hora % 60f);
        int cent = Mathf.FloorToInt((hora * 100f) % 100f);

        string horaFormateada = string.Format("{0:00}:{1:00}:{2:00}", min, seg, cent);
        tiempo.text = "Tiempo: " + horaFormateada;
    }

    public void EnemigoDestruido()
    {
        destruidos++;
        puntos.text = "Destruidos: " + destruidos;
    }


}
