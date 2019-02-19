using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundscript : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        StartCoroutine(timer(5));
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator timer(float t)
    {
        yield return new WaitForSeconds(t);
        Destroy(gameObject);
    }
}