using UnityEngine;
using System.Collections;

public class GoalCube : MonoBehaviour {

		void Start () {
	
	}

    void OnCollisionEnter(Collision col) {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "Sphere")
        {
            Destroy(col.gameObject);
            Goal();
            

        }
    }

    void Goal() {


    }

    void Update () {
	
	}
}
