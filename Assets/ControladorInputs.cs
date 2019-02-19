using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInputs : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        var numero = 1;

        print(numero);
    }

    // Update is called once per frame
    private void Update()
    {
        int quantidadeToques = Input.touchCount;
        print(quantidadeToques);
    }
}