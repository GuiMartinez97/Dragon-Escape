using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerreiro : MonoBehaviour
{
    private Rigidbody2D Physics;
    [SerializeField]
    private float Forca = 5;
    private float ForceReducer = 1;
    [SerializeField]
    private float TimeToGenerate;
    private float Timer;

    private void Awake()
    {
        Physics = GetComponent<Rigidbody2D>();
        Physics.freezeRotation = true;
        Timer = TimeToGenerate;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.Impulsionar();
            AddToForceReducer();
        }

        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            ResetForceReducer();
            Timer = TimeToGenerate;
        }
    }

    private void Impulsionar()
    {
        Physics.velocity = Vector2.zero;
        Physics.AddForce(Vector2.up * Forca / ForceReducer, ForceMode2D.Impulse);
    }

    private void ResetForceReducer()
    {
        ForceReducer = 1;
    }

    private void AddToForceReducer()
    {
        ForceReducer += 1f;
        Timer = TimeToGenerate;
    }
}
