using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerreiro : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 5;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.fisica.freezeRotation = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.Impulsionar();
        }
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }
}
