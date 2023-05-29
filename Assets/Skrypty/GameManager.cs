using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int zycia;
    public int punkty;
    public Text punktyText;
    public Text zyciaText;
    public float timerStart;
    public Text timerText;
    public Pilka p;
    public int liczbaCegiel;
    public bool koniecGry;
    public GameObject koniecGryPanel;
    public InputField nick;
    public Text punktyKoniecGryText;
    float czasGora;

    // Start is called before the first frame update
    void Start()
    {
        czasGora = 900f;
        zycia = 3;
        punkty = 0;
        liczbaCegiel = GameObject.FindGameObjectsWithTag("cegla").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (p.gameObject.GetComponent<Pilka>().czyPilkaWGrze && zycia > 0 && liczbaCegiel > 0) {
            timerStart += Time.deltaTime;
            timerText.text = "Time - " + timerStart.ToString("F2");
        } 
    }
    public void UpdateZycia(int x)
    {
        zycia += x;
        if(zycia <= 0)
        {
            zycia = 0;
            KoniecGry();
        }
        zyciaText.text = "Lives - " + zycia;
    }
    public void UpdatePunkty(int x)
    {
        punkty += x;
        punktyText.text = "Score - " + punkty;
    }
    public void UpdateCegly()
    {
        liczbaCegiel--;
        if(liczbaCegiel == 0)
        {
            KoniecGry();
        }
    }
    public void KoniecGry()
    {
        koniecGry = true;
        punktyKoniecGryText.text = (punkty * (czasGora - timerStart) / 100).ToString("F0");
        koniecGryPanel.SetActive(true);
    }
    public void ZapiszIWyjdz()
    {
        PlayerPrefs.SetString("nowyNick", nick.text);
        PlayerPrefs.SetFloat("nowyWynik", float.Parse(punktyKoniecGryText.text));

        //Pierwszy set prefow test
        /*
        PlayerPrefs.SetString("nick1", "graczTestowy");
        PlayerPrefs.SetFloat("wynik1", 1000f);

        PlayerPrefs.SetString("nick2", "graczTestowy");
        PlayerPrefs.SetFloat("wynik2", 900f);

        PlayerPrefs.SetString("nick3", "graczTestowy");
        PlayerPrefs.SetFloat("wynik3", 800f);

        PlayerPrefs.SetString("nick4", "graczTestowy");
        PlayerPrefs.SetFloat("wynik4", 700f);

        PlayerPrefs.SetString("nick5", "graczTestowy");
        PlayerPrefs.SetFloat("wynik5", 600f);

        PlayerPrefs.SetString("nick6", "graczTestowy");
        PlayerPrefs.SetFloat("wynik6", 500f);

        PlayerPrefs.SetString("nick7", "graczTestowy");
        PlayerPrefs.SetFloat("wynik7", 400f);

        PlayerPrefs.SetString("nick8", "graczTestowy");
        PlayerPrefs.SetFloat("wynik8", 300f);

        PlayerPrefs.SetString("nick9", "graczTestowy");
        PlayerPrefs.SetFloat("wynik9", 200f);

        PlayerPrefs.SetString("nick10", "graczTestowy");
        PlayerPrefs.SetFloat("wynik10", 100f);
        */
        SceneManager.LoadScene("Menu");
    }
}
