using UnityEngine;
using System.Collections;

public class SphereScr : MonoBehaviour {
    public GameObject reset;
	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Bounds")
        {
            transform.LookAt(reset.transform.position);
            GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Impulse);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
