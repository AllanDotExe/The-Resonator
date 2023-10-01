using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : MonoBehaviour
{
    public GameObject brokenEnemy;
    public float breakForce = 2;

    private GameObject frac;
    //private void Update()
    //{
    //    if (Input.GetKeyDown("f"))
    //    {
    //        Break();
    //    }
    //}

    public void Break()
    {
        frac = Instantiate(brokenEnemy, transform.position, transform.rotation);
        foreach (Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>())
        {
            Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            rb.AddForce(force);
        }

        Destroy(gameObject);
    }
}
