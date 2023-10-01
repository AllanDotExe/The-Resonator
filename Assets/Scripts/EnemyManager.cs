using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int maxEnemies;
    public GameObject enemyPrefab;
    public GameObject[] spawnPoints;

    private int currentEnemies = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentEnemies != maxEnemies)
        {
            Instantiate(enemyPrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
            currentEnemies++;
        }
    }

    public void enemyKilled()
    {
        currentEnemies--;
    }
}
