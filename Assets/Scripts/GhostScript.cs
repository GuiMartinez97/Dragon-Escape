using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float velocidade = 5.5f;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.fisica.freezeRotation = true;
        this.fisica.gravityScale = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade);
    }
}
