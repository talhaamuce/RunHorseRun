using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelHareket : MonoBehaviour
{
    GameObject arkaPlan;
    Rigidbody2D fizik;

    void Start()
    {
        arkaPlan = GameObject.FindGameObjectWithTag("arkaplanTag");
        fizik = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        fizik.MovePosition(fizik.position + Vector2.left * arkaPlan.GetComponent<arkaplanHareket>().YerHiz * Time.deltaTime);
    }
}

