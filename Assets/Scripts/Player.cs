using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour
{
    public GameObject deathScreen;
    public FirstPersonController player;
    public ProjectileShooter PS;
    public AudioSource deathSound;

    private bool isDead = false;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Enemy") && (isDead == false))
        {
            Debug.Log("You died!");
            isDead = true;
            deathSound.Play();
            PS.enabled = false;
            player.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            deathScreen.SetActive(true);
        }
    }
}
