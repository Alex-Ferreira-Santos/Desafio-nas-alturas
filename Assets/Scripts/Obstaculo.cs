using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.025f;

    [SerializeField]
    private float variacaoDaPosicaoYBaixo = 2.8f;

    [SerializeField]
    private float variacaoDaPosicaoYCima = 0.8f;

    private Vector3 posicaoDoAviao;
    private Pontuacao pontuacao;
    private bool pontuei;


    void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoYBaixo, variacaoDaPosicaoYCima));
    }

    private void Start()
    {
        posicaoDoAviao = FindObjectOfType<Aviao>().transform.position;
        pontuacao = FindObjectOfType<Pontuacao>();
    }


    // Update is called once per frame

    void Update()
    {
        transform.Translate(Time.deltaTime * velocidade * Vector3.left);

        if (!pontuei && transform.position.x < posicaoDoAviao.x)
        {
            pontuei = true;
            pontuacao.AdicionarPontos();
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}
