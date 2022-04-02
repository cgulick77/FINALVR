using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

     public GameObject platform;
    public GameObject OnPos;
    public GameObject OffPos;
    public bool Activated;

    public float timer;

    private float speed = 10.0f;

    void Start()
    {
        //timer = Random.Range(2,3);
        Activated = true;
    }

    // Update is called once per frame
    void Update()
    {
          // Platforms speed 
        float platformSpeed = speed * Time.deltaTime;

       
       


        // Toggles the platform from On/Off 
        if (Activated == true){
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, OnPos.transform.position, platformSpeed );
            Activated = false;
        } else {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, OffPos.transform.position, platformSpeed );
        }
        

    }
    }


