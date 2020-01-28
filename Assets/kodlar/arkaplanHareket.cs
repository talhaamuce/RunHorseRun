using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arkaplanHareket : MonoBehaviour
{
    public GameObject gokyuzu1, gokyuzu2, yer1, yer2;
    Rigidbody2D fizik1;
    Rigidbody2D fizik2;
    Rigidbody2D fizik3;
    Rigidbody2D fizik4;
    float uzunluk = 0;
    float yeruzun = 0;
    public float YerHiz = 2;
    public float Puan = 0;
    public Text puantext;

    void Start()
    {

        Puan = 0;
        fizik1 = gokyuzu1.GetComponent<Rigidbody2D>();
        fizik2 = gokyuzu2.GetComponent<Rigidbody2D>();



        fizik3 = yer1.GetComponent<Rigidbody2D>();
        fizik4 = yer2.GetComponent<Rigidbody2D>();

        uzunluk = gokyuzu1.GetComponent<BoxCollider2D>().size.x;
        yeruzun = yer1.GetComponent<BoxCollider2D>().size.x;

    }

    void Update()
    {


        if (gokyuzu1.transform.position.x <= -uzunluk)
            gokyuzu1.transform.position += new Vector3(uzunluk * 2, 0);


        if (gokyuzu2.transform.position.x <= -uzunluk)
            gokyuzu2.transform.position += new Vector3(uzunluk * 2, 0);

        if (yer1.transform.position.x <= -uzunluk)
            yer1.transform.position += new Vector3(uzunluk * 2, 0);

        if (yer2.transform.position.x <= -uzunluk)
            yer2.transform.position += new Vector3(uzunluk * 2, 0);

        fizik3.velocity = new Vector2(-YerHiz, 0);
        fizik4.velocity = new Vector2(-YerHiz, 0);

        fizik1.velocity = new Vector2(-YerHiz / 8f, 0);
        fizik2.velocity = new Vector2(-YerHiz / 8f, 0);
        Puan = Puan + 1;
        puantext.text = "Puan:" + Puan;
        PlayerPrefs.SetFloat("puan", Puan);


        var yuksekSkor = PlayerPrefs.GetFloat("yuksekSkor");
        Debug.Log(yuksekSkor);
        if (Puan > yuksekSkor)
        {
            PlayerPrefs.SetFloat("yuksekSkor", Puan);
        }


        if (Puan % 1000 == 0)
        {
            //Debug.Log(Puan);
            YerHiz = YerHiz + 1;
        }


    }



}
