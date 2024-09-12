using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_spawn : MonoBehaviour
{
    public GameObject coin;
    public float spawnrate= 4;
    public float timer = 2;
    public float heightpipe = 10;
    private bool espaceAppuye = false;
    public int updown = 1;
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
            if(updown==1){
                updown=0;
                spawncoin1();
                timer=0;
            }else{
                updown=1;
                spawncoin2();
                timer=0;
            }
        }   
        }
    }

void spawncoin1(){
        float lowestpoint = -heightpipe;
        float highestpoint = heightpipe;

        Instantiate(coin,new Vector3(transform.position.x, 10 + Random.Range(lowestpoint,highestpoint),0),transform.rotation);
        
    }

    void spawncoin2(){
        float lowestpoint = -heightpipe;
        float highestpoint =  +heightpipe;

        Instantiate(coin,new Vector3(transform.position.x,-10 + Random.Range(lowestpoint,highestpoint),0),transform.rotation);
        
    }
}