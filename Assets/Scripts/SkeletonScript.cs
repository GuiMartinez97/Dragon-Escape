using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonScript : MonoBehaviour
{
    private Rigidbody2D fisica;
    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.fisica.freezeRotation = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
