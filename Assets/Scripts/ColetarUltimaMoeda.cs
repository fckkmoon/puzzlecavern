using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ColetarUltimaMoeda : MonoBehaviour
{ 
    public string Créditos;
    public GameObject Moedas;
    
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.gameObject.tag == "Moeda6")
        {
            Destroy(hit.gameObject);
            SceneManager.LoadScene(Créditos);
        }
    }
}