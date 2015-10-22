using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AssignKeys : MonoBehaviour {

    public static AssignKeys AssInstance;
    public List<PlayerControl> playerctrl;
    void Awake() {
        AssInstance = this;
    }

    public string[] texts = new string[9];

	void Start () {
        playerctrl = new List<PlayerControl>();
	
	}

    
	
	// Update is called once per frame
	void Update () {
	
	}
}
