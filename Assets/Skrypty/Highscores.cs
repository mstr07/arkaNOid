using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour
{
    public Text[] gracze;
    public Text[] wyniki;
    // Start is called before the first frame update
    void Start()
    {
        //UpdateHighScores();

        //UpdateHighScoresTable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHighScores()
    {
        //1st
        if(PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik1"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("wynik7"));
            PlayerPrefs.SetFloat("wynik7", PlayerPrefs.GetFloat("wynik6"));
            PlayerPrefs.SetFloat("wynik6", PlayerPrefs.GetFloat("wynik5"));
            PlayerPrefs.SetFloat("wynik5", PlayerPrefs.GetFloat("wynik4"));
            PlayerPrefs.SetFloat("wynik4", PlayerPrefs.GetFloat("wynik3"));
            PlayerPrefs.SetFloat("wynik3", PlayerPrefs.GetFloat("wynik2"));
            PlayerPrefs.SetFloat("wynik2", PlayerPrefs.GetFloat("wynik1"));
            PlayerPrefs.SetFloat("wynik1", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nick7"));
            PlayerPrefs.SetString("nick7", PlayerPrefs.GetString("nick6"));
            PlayerPrefs.SetString("nick6", PlayerPrefs.GetString("nick5"));
            PlayerPrefs.SetString("nick5", PlayerPrefs.GetString("nick4"));
            PlayerPrefs.SetString("nick4", PlayerPrefs.GetString("nick3"));
            PlayerPrefs.SetString("nick3", PlayerPrefs.GetString("nick2"));
            PlayerPrefs.SetString("nick2", PlayerPrefs.GetString("nick1"));
            PlayerPrefs.SetString("nick1", PlayerPrefs.GetString("nowyNick"));
        }
        //2nd
        if(PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik1") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik2"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("wynik7"));
            PlayerPrefs.SetFloat("wynik7", PlayerPrefs.GetFloat("wynik6"));
            PlayerPrefs.SetFloat("wynik6", PlayerPrefs.GetFloat("wynik5"));
            PlayerPrefs.SetFloat("wynik5", PlayerPrefs.GetFloat("wynik4"));
            PlayerPrefs.SetFloat("wynik4", PlayerPrefs.GetFloat("wynik3"));
            PlayerPrefs.SetFloat("wynik3", PlayerPrefs.GetFloat("wynik2"));
            PlayerPrefs.SetFloat("wynik2", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nick7"));
            PlayerPrefs.SetString("nick7", PlayerPrefs.GetString("nick6"));
            PlayerPrefs.SetString("nick6", PlayerPrefs.GetString("nick5"));
            PlayerPrefs.SetString("nick5", PlayerPrefs.GetString("nick4"));
            PlayerPrefs.SetString("nick4", PlayerPrefs.GetString("nick3"));
            PlayerPrefs.SetString("nick3", PlayerPrefs.GetString("nick2"));
            PlayerPrefs.SetString("nick2", PlayerPrefs.GetString("nowyNick"));
        }
        //3rd
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik2") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik3"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("wynik7"));
            PlayerPrefs.SetFloat("wynik7", PlayerPrefs.GetFloat("wynik6"));
            PlayerPrefs.SetFloat("wynik6", PlayerPrefs.GetFloat("wynik5"));
            PlayerPrefs.SetFloat("wynik5", PlayerPrefs.GetFloat("wynik4"));
            PlayerPrefs.SetFloat("wynik4", PlayerPrefs.GetFloat("wynik3"));
            PlayerPrefs.SetFloat("wynik3", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nick7"));
            PlayerPrefs.SetString("nick7", PlayerPrefs.GetString("nick6"));
            PlayerPrefs.SetString("nick6", PlayerPrefs.GetString("nick5"));
            PlayerPrefs.SetString("nick5", PlayerPrefs.GetString("nick4"));
            PlayerPrefs.SetString("nick4", PlayerPrefs.GetString("nick3"));
            PlayerPrefs.SetString("nick3", PlayerPrefs.GetString("nowyNick"));
        }
        //4th
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik3") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik4"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("wynik7"));
            PlayerPrefs.SetFloat("wynik7", PlayerPrefs.GetFloat("wynik6"));
            PlayerPrefs.SetFloat("wynik6", PlayerPrefs.GetFloat("wynik5"));
            PlayerPrefs.SetFloat("wynik5", PlayerPrefs.GetFloat("wynik4"));
            PlayerPrefs.SetFloat("wynik4", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nick7"));
            PlayerPrefs.SetString("nick7", PlayerPrefs.GetString("nick6"));
            PlayerPrefs.SetString("nick6", PlayerPrefs.GetString("nick5"));
            PlayerPrefs.SetString("nick5", PlayerPrefs.GetString("nick4"));
            PlayerPrefs.SetString("nick4", PlayerPrefs.GetString("nowyNick"));
        }
        //5th
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik4") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik5"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("wynik7"));
            PlayerPrefs.SetFloat("wynik7", PlayerPrefs.GetFloat("wynik6"));
            PlayerPrefs.SetFloat("wynik6", PlayerPrefs.GetFloat("wynik5"));
            PlayerPrefs.SetFloat("wynik5", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nick7"));
            PlayerPrefs.SetString("nick7", PlayerPrefs.GetString("nick6"));
            PlayerPrefs.SetString("nick6", PlayerPrefs.GetString("nick5"));
            PlayerPrefs.SetString("nick5", PlayerPrefs.GetString("nowyNick"));
        }
        //6th
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik5") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik6"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("wynik7"));
            PlayerPrefs.SetFloat("wynik7", PlayerPrefs.GetFloat("wynik6"));
            PlayerPrefs.SetFloat("wynik6", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nick7"));
            PlayerPrefs.SetString("nick7", PlayerPrefs.GetString("nick6"));
            PlayerPrefs.SetString("nick6", PlayerPrefs.GetString("nowyNick"));
        }
        //7th
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik6") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik7"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("wynik7"));
            PlayerPrefs.SetFloat("wynik7", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nick7"));
            PlayerPrefs.SetString("nick7", PlayerPrefs.GetString("nowyNick"));
        }
        //8th
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik7") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik8"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("wynik8"));
            PlayerPrefs.SetFloat("wynik8", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nick8"));
            PlayerPrefs.SetString("nick8", PlayerPrefs.GetString("nowyNick"));
        }
        //9th
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik8") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik9"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("wynik9"));
            PlayerPrefs.SetFloat("wynik9", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nick9"));
            PlayerPrefs.SetString("nick9", PlayerPrefs.GetString("nowyNick"));
        }
        //10th
        if (PlayerPrefs.GetFloat("nowyWynik") < PlayerPrefs.GetFloat("wynik9") && PlayerPrefs.GetFloat("nowyWynik") > PlayerPrefs.GetFloat("wynik10"))
        {
            PlayerPrefs.SetFloat("wynik10", PlayerPrefs.GetFloat("nowyWynik"));

            PlayerPrefs.SetString("nick10", PlayerPrefs.GetString("nowyNick"));
        }
    }

    public void UpdateHighScoresTable()
    {
        //Wypisanie tabeli
        gracze[0].text = PlayerPrefs.GetString("nick1");
        wyniki[0].text = PlayerPrefs.GetFloat("wynik1").ToString();

        gracze[1].text = PlayerPrefs.GetString("nick2");
        wyniki[1].text = PlayerPrefs.GetFloat("wynik2").ToString();

        gracze[2].text = PlayerPrefs.GetString("nick3");
        wyniki[2].text = PlayerPrefs.GetFloat("wynik3").ToString();

        gracze[3].text = PlayerPrefs.GetString("nick4");
        wyniki[3].text = PlayerPrefs.GetFloat("wynik4").ToString();

        gracze[4].text = PlayerPrefs.GetString("nick5");
        wyniki[4].text = PlayerPrefs.GetFloat("wynik5").ToString();

        gracze[5].text = PlayerPrefs.GetString("nick6");
        wyniki[5].text = PlayerPrefs.GetFloat("wynik6").ToString();

        gracze[6].text = PlayerPrefs.GetString("nick7");
        wyniki[6].text = PlayerPrefs.GetFloat("wynik7").ToString();

        gracze[7].text = PlayerPrefs.GetString("nick8");
        wyniki[7].text = PlayerPrefs.GetFloat("wynik8").ToString();

        gracze[8].text = PlayerPrefs.GetString("nick9");
        wyniki[8].text = PlayerPrefs.GetFloat("wynik9").ToString();

        gracze[9].text = PlayerPrefs.GetString("nick10");
        wyniki[9].text = PlayerPrefs.GetFloat("wynik10").ToString();
    }
}
