using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomNesne : MonoBehaviour
{

    Vector2 vec;
    public GameObject engel1;
    public GameObject engel2;
    public GameObject engel3;
    GameObject arkaPlan;
    public bool oyunDevamEdiyormu = true;
    void Start()
    {
        arkaPlan = GameObject.FindGameObjectWithTag("arkaplanTag");
        StartCoroutine(gel());

    }
    // Use this for initialization
    void Update()
    {
    }

    IEnumerator gel()
    {
        while (oyunDevamEdiyormu)
        {
            yield return new WaitForSeconds(2f); //2 saniye bekleme

            var NesneSayisi = Random.Range(0, 2);

            for (int b = 0; b <= NesneSayisi; b++)
            {
                int randomnesne = Random.Range(1, 4);
                vec = new Vector2(12.61f + b / 2f, -1.30f);


                if (randomnesne == 1)
                {
                    var obje = Instantiate(engel1, vec, Quaternion.identity);
                    obje.transform.localScale = new Vector3(Random.Range(4, 6) / 10f, Random.Range(5, 7) / 10f);

                }
                if (randomnesne == 2)
                {

                    var obje = Instantiate(engel2, vec, Quaternion.identity);
                    obje.transform.localScale = new Vector3(Random.Range(4, 6) / 10f, Random.Range(5, 7) / 10f);

                }
                if (randomnesne == 3)
                {
                    var obje = Instantiate(engel3, vec, Quaternion.identity);
                    obje.transform.localScale = new Vector3(Random.Range(4, 5) / 10f, Random.Range(5, 7) / 10f);
                }

            }


            yield return new WaitForSeconds(2f);
        }





    }
}
