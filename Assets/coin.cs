using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class coin : MonoBehaviour
{
    public logicscript logic;
    private bool espaceAppuye = false;
    [SerializeField] private int value;
    private bool hastriggered;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("puffle") && !hastriggered){
            hastriggered = true;
            logic.addscore(5);
            Destroy(gameObject);
        }

    }

 void Update(){
       movingobject();
 }

public void movingobject(int moveSpeed2=7 , int deadzone2 = -50, string message = "pipe deleted"){
         transform.position = transform.position + (Vector3.left * moveSpeed2) * Time.deltaTime;
        if(transform.position.x < deadzone2){
            Destroy(gameObject);
            Debug.Log(message);
        }
}

}
