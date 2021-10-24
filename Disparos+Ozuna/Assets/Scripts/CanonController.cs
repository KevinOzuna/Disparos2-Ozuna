using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public Vector3 spawnPosition = new Vector3(5, 1, 9);
    public float firstBulletDelay = 1.0f;
    public float bulletCoolDown = 3.0f;
    public GameObject bullet; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", firstBulletDelay, bulletCoolDown);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Shoot()
    {
        Instantiate(bullet, spawnPosition, bullet.transform.rotation);
    }
    
}
