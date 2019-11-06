using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5.5f;
    private float cronometro;


    private void Awake()
    {
        cronometro = 15;
    }
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x<-15)
        //cronometro -= Time.deltaTime;
        //if (cronometro < 0)
            Destroy(gameObject);

        this.transform.Translate(Vector3.left * this.velocidade);
    }
}
