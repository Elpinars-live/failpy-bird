using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puffle_test : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public float flapstrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
        myRigibody.velocity = Vector2.up * flapstrength;    
        }
        

    }
}
