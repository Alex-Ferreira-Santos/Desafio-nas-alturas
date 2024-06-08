using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.025f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidade);
    }
}
