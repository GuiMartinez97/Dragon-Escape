using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonScript : MonoBehaviour
{
    private Rigidbody2D fisica;
    private float cronometro;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.fisica.freezeRotation = true;
        cronometro = 15;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -15)
            //cronometro -= Time.deltaTime;
            //if (cronometro < 0)
            Destroy(gameObject);

    }
}
