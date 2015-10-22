using UnityEngine;
using System.Collections;

public class Remains : MonoBehaviour {
    float timer = 4f;

	// Use this for initialization
	void Start () {
        Physics.IgnoreLayerCollision(8, 9, true);
	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer<0)
        {
            Destroy(gameObject);
        }
	}
}
