using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    public GameObject Target;
    public float speed = 1.5f;

    public EnemyManager EM;
    public Shatter S;
    // Start is called before the first frame update
    void Start()
    {
        EM = GameObject.FindGameObjectWithTag("EnemyManager").GetComponent<EnemyManager>();
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.gameObject.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Debug.Log("Hit!");
            S.Break();
            Die();
        }
    }

    private void Die()
    {
        EM.enemyKilled();
        Destroy(this.gameObject);
    }
}
