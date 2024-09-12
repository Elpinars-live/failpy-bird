using System.Collections;
using System.Collections.Generic;
using System.Data;
using JetBrains.Annotations;
using UnityEngine;

public class pipe_spawner_script : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate= 4;
    public float timer = 2;
    public float heightpipe = 10;
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
      if(timer < spawnrate){
            timer += Time.deltaTime;
        }else{
            spawnpipe();
            timer=0;
        }
    }
    }
    void spawnpipe(){
        float lowestpoint = transform.position.y - heightpipe;
        float highestpoint = transform.position.y + heightpipe;

        Instantiate(pipe,new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint),0),transform.rotation);
        
    }

public void movingobject(int moveSpeed2=5 , int deadzone2 = -50, string message = "pipe deleted"){
         transform.position = transform.position + (Vector3.left * moveSpeed2) * Time.deltaTime;
        if(transform.position.x < deadzone2){
            Destroy(gameObject);
            Debug.Log(message);
        }
}

}
