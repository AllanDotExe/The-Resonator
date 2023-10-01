using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ObjectiveManager : MonoBehaviour
{
    private int currentPoints = 0;
    private bool won = false;

    public FirstPersonController FPC;
    public ProjectileShooter PS;
    public GameObject player;

    public GameObject winScreen;
    public int requiredPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((currentPoints == requiredPoints) && (won == false))
        {
            Debug.Log("You Win!");
            won = true;
            PS.enabled = false;
            FPC.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            player.SetActive(false);
            winScreen.SetActive(true);
        }
    }

    public void increasePoints(int gainedPoints)
    {
        currentPoints = currentPoints + gainedPoints;
    }
}
