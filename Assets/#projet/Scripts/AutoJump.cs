using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJump : MonoBehaviour
{

    Rigidbody rb;
    public Vector3 verticalForce;
    public Vector3 additionalForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity == Vector3.zero) {
            rb.AddForce(verticalForce);
            verticalForce += additionalForce;
        } 
        // si le rigidbody est immobile 
        // alors lui donner une force vers le haut 
        // augmenter la force de x pour la prochaine fois 
        

    }
}
