using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBill : MonoBehaviour
{
    AudioSource NovaShot;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform shotPosition;
    [SerializeField] float shotForce;
    [SerializeField] float lifeTime;
    [SerializeField] float shotPeriod;

    float shotTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && shotTime <= 0)
        {
            
            GameObject newbullet = Instantiate(bullet, shotPosition.position, transform.rotation);
            Rigidbody2D rb = newbullet.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * shotForce);
            Destroy(newbullet, lifeTime);
            shotTime=shotPeriod;
            NovaShot.Play();
        }
        shotTime -= Time.deltaTime;
     
    }
}
