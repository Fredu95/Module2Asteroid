using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{   
    Rigidbody2D rb;
    ParticleSystem particles;
    [SerializeField]
    float thrust = 20;
    
   
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        particles = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
if (Input.GetButton("Jump"))
        {
        rb.AddForce(transform.up * thrust * Time.deltaTime);
        //Liikkuu eteenpain
        if(! particles.isEmitting)
        particles.Play();
        }
    else
        {
        if (particles.isEmitting)
    {
    particles.Stop();
    }
        }

    float xInput= Input.GetAxis("Horizontal");
    float speed = 50;

    gameObject.transform.Rotate(new Vector3(0f, 0f, -xInput * Time.deltaTime * speed)); //Kaantyy paikallaan

    }


void OnCollisionEnter2D(Collision2D other)
{
 Debug.Log("coli");   
}

}
