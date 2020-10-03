using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject platformPrefab;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        //spawned as a child of the current object
        //Instantiate(platformPrefab, transform);
        //spawned at specific coordinates
        //Instantiate(platformPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - player.transform.position.x < 70) {
            //spawn a platform
            Vector3 offset = Random.Range(-3f, 3) * Vector3.up;
            Instantiate(platformPrefab, transform.position + offset, Quaternion.identity);
            //move spawner
            transform.position += Vector3.right * 20;
        }
    }

    
}
