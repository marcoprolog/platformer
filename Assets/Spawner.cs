using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject platformPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //spawned as a child of the current object
        //Instantiate(platformPrefab, transform);
        //spawned at specific coordinates
        Instantiate(platformPrefab, new Vector3(1, 2, 3), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
