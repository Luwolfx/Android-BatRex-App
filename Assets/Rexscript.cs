using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rexscript : MonoBehaviour
{
    private float ang;
    public GameObject som;

    // Use this for initialization
    private void Start()
    {
        ang = -10;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(Vector3.forward * ang);

        if (Input.GetButtonDown("Fire1"))
        {
            ang = 0;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            Instantiate(som);
            ang = -10;
        }
    }
}