using UnityEngine;
using System.Collections;

public class Resetter : MonoBehaviour {
    public GameObject[] StartPoints = new GameObject[4];
    public GameObject[] Characters = new GameObject[5];
    public GameObject[] LivePlayers = new GameObject[4];

    public int[] score = new int[4];


    public StartGame sg;
	void Start () {
        StartCoroutine("StartGame");
        StartCoroutine("ResetGame");
	}

    IEnumerator StartGame() {
        while (sg == null)
        {
            sg = GameObject.FindGameObjectWithTag("StartControl").GetComponent<StartGame>();
            yield return null;
        }
        StartBattle(sg.num);
    }


    public void StartBattle(int num) {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Player"))
        {
            DestroyObject(item);
        }
        for (int i = 0; i < num; i++)
        {
            CreatePlayer(StartPoints[i],i);

        }
    }

    void CreatePlayer(GameObject go, int playernumber) {
        int rand = Random.Range(0, 4);

        GameObject ngo = Instantiate(Characters[rand], go.transform.position, go.transform.rotation) as GameObject;
        ngo.GetComponent<PlayerControl>().actionKey = sg.keys[playernumber];


    }

    IEnumerator ResetGame() {
        while (true)
        {
            yield return new WaitForSeconds(3);
            if (GameObject.FindGameObjectsWithTag("Player").Length <= 1)
            {
                StartBattle(sg.num);
            }
        }
    }

	void Update () {
     
	}
}
