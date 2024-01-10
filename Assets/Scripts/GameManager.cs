using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set; }

    public void LoadJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("Se salio del juego");
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            CerrarJuego();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadJuego();
            Debug.Log("Inicio del juego");
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Menu();
            Debug.Log("Vuelta al menu");
        }


    }

}