using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{

    float puan=0, yuksekSkorF=0;
    public Text puanscore;
    public Text yuksekSkor;
    void Start()
    {

        puan = PlayerPrefs.GetFloat("puan");

        if (puan != 0)
            puanscore.text = "SON OYUN SKORU:" + puan;
        else
            puanscore.text = "";
        yuksekSkorF = PlayerPrefs.GetFloat("yuksekSkor");

        if (yuksekSkorF != 0)
            yuksekSkor.text = "EN YÜKSEK SKOR:" + yuksekSkorF;
        else if (puan != 0)
        {
            yuksekSkor.text = "EN YÜKSEK SKOR:" + puan;
        }
        else
        {
            yuksekSkor.text = "";
        }


    }


    void Update()
    {

    }

    public void basla()
    {

        SceneManager.LoadScene("game");
    }

    public void cıkıs()
    {
        Application.Quit();
    }

}
