using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGry()
    {
        SceneManager.LoadScene("Gra");
    }
    public void KoniecGry()
    {
        Debug.Log("Koniec");
        Application.Quit();
    }
}
