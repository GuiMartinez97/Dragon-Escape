using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;
    [SerializeField]
    private GameObject PointedObstacle;
    [SerializeField]
    private GameObject OneBlockObstacle;
    [SerializeField]
    private GameObject TwoBlockObstacle;
    [SerializeField]
    private GameObject ThreeBlockObstacle;

    private Random Random = new Random();

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
            int randomNumber = Random.Range(1, 4);

            switch (randomNumber)
            {
                case 1:
                    {
                        Instantiate(this.PointedObstacle, this.transform.position, Quaternion.identity);
                        break;
                    }
                case 2:
                    {
                        //Instantiate(this.OneBlockObstacle, this.transform.position, Quaternion.identity);
                        InstantiateBlockObstacle(this.OneBlockObstacle, this.transform.position);
                        break;
                    }
                case 3:
                    {
                        //Instantiate(this.TwoBlockObstacle, this.transform.position, Quaternion.identity);
                        InstantiateBlockObstacle(this.TwoBlockObstacle, this.transform.position);
                        break;
                    }
                case 4:
                    {
                        //Instantiate(this.ThreeBlockObstacle, this.transform.position, Quaternion.identity);
                        InstantiateBlockObstacle(this.ThreeBlockObstacle, this.transform.position);
                        break;
                    }
            }

            
            cronometro = tempoParaGerar;
        }
    }

    private void InstantiateBlockObstacle(GameObject _blockObstacle, Vector3 _position)
    {
        float randomNumber = Random.Range(-0.9f, -3.92f);
        Vector3 startingPosition = new Vector3(_position.x, randomNumber, _position.y);
        Instantiate(_blockObstacle, startingPosition, Quaternion.identity);
    }
}
