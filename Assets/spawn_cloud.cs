using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_cloud : MonoBehaviour
{
    public GameObject cloud;
    public float spawnrate= 15;
    public float timer = 0;
    public float heightpipe = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawncloud();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate){
            timer += Time.deltaTime;
        }else{
            spawncloud();
            timer=0;
        }
    }

    void spawncloud(){
        float lowestpoint = transform.position.y - heightpipe;
        float highestpoint = transform.position.y + heightpipe;

        Instantiate(cloud,new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint),0),transform.rotation);
        
    }
}
