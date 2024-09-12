using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingstart : MonoBehaviour
{
    public float moveSpeed2 = 5;
    private bool espaceAppuye = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            espaceAppuye = true;
        }
         if (espaceAppuye)
        {
       movingobject();
    }
    }
    public void movingobject(int moveSpeed2=5 , int deadzone2 = -50, string message = "pipe deleted"){
         transform.position = transform.position + (Vector3.left * moveSpeed2) * Time.deltaTime;
        if(transform.position.x < deadzone2){
            Destroy(gameObject);
            Debug.Log(message);
        }
    } 
public void test()
{Debug.Log("e");
}
}
