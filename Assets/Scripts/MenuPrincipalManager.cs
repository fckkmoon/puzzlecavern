using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string PrimeiraFase;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelAjustes;

    public void Jogar()
    {
        SceneManager.LoadScene(PrimeiraFase);
    }

    public void AbrirAjustes()
    {
        painelMenuInicial.SetActive(false);
        painelAjustes.SetActive(true);
    }

    public void FecharAjustes()
    {
        painelAjustes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
