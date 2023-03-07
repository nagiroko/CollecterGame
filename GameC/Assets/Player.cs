using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int score = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        transform.position = pos;
        if (Input.GetKey(KeyCode.W))
        {
            pos.z += .01f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.z -= .01f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= .01f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += .01f;
        }
        transform.position = pos;

    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Hit");
        if(other.tag == "Collectable")
        {
            score += 1;
            Destroy(other.gameObject);
            Debug.Log(score);
        }
    }


}
