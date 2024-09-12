using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moving_pipes : MonoBehaviour
{
  public float moveSpeed = 5;
  public float deadzone = -50;
  public movingstart move;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        Debug.Log("pipe deleted");
        if(transform.position.x < deadzone){
            Destroy(gameObject);
        }
    }
}
