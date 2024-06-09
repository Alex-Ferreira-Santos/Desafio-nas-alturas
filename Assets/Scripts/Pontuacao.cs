using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    private int pontos;
    private AudioSource audioPontuacao;

    private void Awake()
    {
        audioPontuacao = GetComponent<AudioSource>();
    }
    public void AdicionarPontos()
    {
        pontos++;
        textoPontuacao.text = pontos.ToString();
        audioPontuacao.Play();
    }

    public void Reiniciar()
    {
        pontos = 0;
        textoPontuacao.text = pontos.ToString();
    }
}
