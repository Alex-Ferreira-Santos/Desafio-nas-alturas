using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;
    [SerializeField]
    private GameObject manualDeInstrucoes;

    void Awake()
    {
        cronometro = tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro < 0)
        {
            Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }

}
