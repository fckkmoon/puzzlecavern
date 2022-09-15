using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColetarMoeda : MonoBehaviour
{
    public GameObject Moedas;
    
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.gameObject.tag == "Moeda")
        {
            Destroy(hit.gameObject);
        }
    }
}


