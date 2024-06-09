using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private Aviao aviao;

    void Start()
    {
        aviao = FindObjectOfType<Aviao>();
    }
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        aviao.Reiniciar();
        DestruirObstaculos();
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
