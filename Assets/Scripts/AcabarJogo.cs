using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcabarJogo : MonoBehaviour
{
    public string Créditos;
    public GameObject PortaAberta;

     private void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "PortaAberta")
        {
            SceneManager.LoadScene(Créditos);
        }
    }
}
