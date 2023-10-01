using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuningForks : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject model;

    public int pointsGained = 1;
    public ObjectiveManager OM;

    public AudioSource tuned_sfx;

    private bool isTuned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile" && !isTuned)
        {
            Debug.Log("Tuning Fork Tuned!");
            OM.increasePoints(pointsGained);
            tuned_sfx.Play();
            updateEffect();
            isTuned = true;
        }
    }

    private void updateEffect()
    {
        var effectInstance = Instantiate(Prefab) as GameObject;
        var psUpdater = effectInstance.GetComponent<PSMeshRendererUpdater>();
        psUpdater.UpdateMeshEffect(model);
    }
}
