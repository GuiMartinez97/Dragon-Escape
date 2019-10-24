using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeMonstros : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;
    [SerializeField]
    private GameObject Skeleton;
    [SerializeField]
    private GameObject Ghost;
    private Random Random = new Random();

    private void Awake()
    {
        cronometro = this.tempoParaGerar;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro < 0)
        {
            int randomNumber = Random.Range(1, 3);

            switch(randomNumber)
            {
                case 1:
                    {
                        Instantiate(this.Skeleton, this.transform.position, Quaternion.identity);
                        break;
                    }
                case 2:
                    {
                        Instantiate(this.Ghost, this.transform.position, Quaternion.identity);
                        break;
                    }
            }
            cronometro = tempoParaGerar;
        }
    }
}
