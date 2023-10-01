using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public float growthPower;
    Vector3 vec;

    private void Start()
    {
        vec = new Vector3(growthPower, growthPower, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = transform.localScale + vec;
    }
}
