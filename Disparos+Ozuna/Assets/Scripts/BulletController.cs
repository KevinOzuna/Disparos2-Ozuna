using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 5.0f;
    public float timeBullet = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tecla espacio presionada");
            ChangeScale();
        }
        else
        {

        }

        timeBullet -= Time.deltaTime;
        if (timeBullet > 0)
        {
            Movement(Vector3.forward);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Movement(Vector3 direction)
    {
        transform.Translate(speed * direction * Time.deltaTime);
    }

    private void ChangeScale()
    {
        gameObject.transform.localScale *= 2;
    }
}