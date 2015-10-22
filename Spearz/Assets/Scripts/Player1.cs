using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour
{

float flailing = 300;
public float thrust = 200;
public float maxThrust = 400;
   
public static string actionKey = "w";



// Use this for initialization
void Start()
{
StartCoroutine("Spinner");
}


IEnumerator Spinner()
{
while (true)
{

    if (Input.GetKey(actionKey) != true)
    {


        transform.RotateAround(transform.position, Vector3.up, -flailing * Time.deltaTime);
    }
    yield return null;
}

}
IEnumerator Charger()
{
while (Input.GetKey(actionKey) && thrust<maxThrust) { 
yield return new WaitForSeconds(0.000000000001f);
thrust += 20;
}
GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
thrust = 200;
}

    

// Update is called once per frame
void Update()
{

if (Input.GetKeyDown(actionKey))
{
    StartCoroutine("Charger");
}

}
}