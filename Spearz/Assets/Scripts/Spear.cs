using UnityEngine;
using System.Collections;

public class Spear : MonoBehaviour {
    public GameObject ramains;
	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.tag == "Player")
        {
            Instantiate(ramains, col.transform.localPosition, col.transform.localRotation);
            DestroyObject(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
