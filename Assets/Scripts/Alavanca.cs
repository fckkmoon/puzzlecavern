using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alavanca : MonoBehaviour
{
     public string SegundaFase;
     public GameObject AlavancaAbrir;

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.gameObject.tag == "Alavanca")
            SceneManager.LoadScene(SegundaFase);
    }
}
