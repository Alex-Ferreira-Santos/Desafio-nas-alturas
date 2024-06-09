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


    void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoYBaixo, variacaoDaPosicaoYCima));
    }
    // Update is called once per frame

    void Update()
    {
        transform.Translate(Time.deltaTime * velocidade * Vector3.left);
    }

    void OnTriggerEnter2D(Collider2D outro){
        Destroy(gameObject);
    }
}
