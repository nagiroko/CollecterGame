using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{

    public GameObject collectable;
    float x;
    float z;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        for(int i = 0; i < 10; i++)
        {
            x = Random.Range(-5, 10);
            z = Random.Range(-5, 10);
            pos = new Vector3(x, 1, z);
            Instantiate(collectable, pos, Quaternion.identity);
        }
    }
}
