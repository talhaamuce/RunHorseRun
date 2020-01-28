using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelSilme : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "engelTag")
        {
            Destroy(col.gameObject);
        }






    }
}
