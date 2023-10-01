using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject prjectile;
    public Transform attackSpawnPoint;
    public float projectileSpeed;
    public float burstRate;

    public int burstSize = 4;
    public AudioSource attack_sfx;

    public float coolDown = 2;

    private float lastShot;

    // Start is called before the first frame update
    void Start()
    {
        //prefab = Resources.Load("projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    private void shoot()
    {
        float rate = 0;

        if (Time.time - lastShot < coolDown)
        {
            return;
        }
        lastShot = Time.time;
        attack_sfx.Play();

        for (int i = 0; i < burstSize; i++)
        {
            //Debug.Log("Fired!"); 
            Invoke("burst", rate);
            rate = rate + burstRate;
        }
    }

    private void burst()
    {
        GameObject projectile = Instantiate(prjectile, attackSpawnPoint.position, attackSpawnPoint.rotation);
        projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * projectileSpeed;
    }
}
