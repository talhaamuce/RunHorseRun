using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class karakter : MonoBehaviour
{

    public Sprite[] at;
    int sayac = 0;
    SpriteRenderer spriterenderer;
    Rigidbody2D fizik;
    Vector2 vec;
    public float Puan = 0;
    float animasyonzaman = 0;
    GameObject engeller;
    GameObject arkaPlan;

    AudioSource[] ses;

    void Start()
    {
        ses = GetComponents<AudioSource>();
        fizik = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        engeller = GameObject.FindGameObjectWithTag("engellerTag");
        arkaPlan = GameObject.FindGameObjectWithTag("arkaplanTag");

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && transform.position.y <= -0.67 && engeller.GetComponent<randomNesne>().oyunDevamEdiyormu)
        {
            fizik.velocity = new Vector2(0, 0);
            vec = new Vector2(0, 330);
            fizik.AddForce(vec);
            ses[0].Play();
        }
        if (transform.position.y <= -0.67)
            animasyon();

    }

    void animasyon()
    {
        if (engeller.GetComponent<randomNesne>().oyunDevamEdiyormu)
        {


            animasyonzaman += Time.deltaTime;

            if (animasyonzaman > 0.05f)
            {

                animasyonzaman = 0;

                spriterenderer.sprite = at[sayac];
                sayac++;

                if (sayac >= at.Length)
                {
                    sayac = 0;

                }
            }

        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "engelTag")
        {
            //Debug.Log("değdi");
            engeller.GetComponent<randomNesne>().oyunDevamEdiyormu = false;
            arkaPlan.GetComponent<arkaplanHareket>().YerHiz = 0;
            ses[1].Play();
            GameObject.FindGameObjectWithTag("reklam").GetComponent<reklam>().reklamiGetir();
            SceneManager.LoadScene("menu");
        }






    }
}
