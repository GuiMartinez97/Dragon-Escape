using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    Text instruction;
    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;
    // Start is called before the first frame update

    private void Awake()
    {
        cronometro = this.tempoParaGerar;
    }
    void Start()
    {
        instruction = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        double currentPoints = Convert.ToDouble(instruction.text);
        currentPoints += 0.01;
        instruction.text = currentPoints.ToString();

        cronometro = tempoParaGerar;
    }
}
