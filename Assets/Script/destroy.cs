using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float defend;
    
    Rigidbody2D rb;
    bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude > defend)
        {
            
            Destroy(gameObject, 0.1f);
        }
    }
}
