﻿using UnityEngine;
using System.Collections;

public class Spearman2 : MonoBehaviour {

    float flailing = 300;
    float thrust = 400;



    // Use this for initialization
    void Start()
    {
        StartCoroutine("Spinner");
    }


    IEnumerator Spinner()
    {
        while (true)
        {

            if (Input.GetKey("w") != true)
            {


                transform.RotateAround(transform.position, Vector3.up, -flailing * Time.deltaTime);
            }
            yield return null;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {

            GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
        }
    }
}
