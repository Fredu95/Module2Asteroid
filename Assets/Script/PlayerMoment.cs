using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{   
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
if (Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(new Vector2(0,30));
    }
if (Input.GetKeyDown(KeyCode.A))
    {
    
    }

    }
}
