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

    private void Awake()
    {
        cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;
        if(cronometro < 0)
        {
            GameObject.Instantiate(this.manualDeInstrucoes, this.transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}
