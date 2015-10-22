using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartGame : MonoBehaviour
{

    public string[] keys = new string[4];
    public string[] instructs = new string[4];
    public int num = 0;
    public Text[] txt = new Text[4];


    void Start()
    {
        instructs[0] = "Player 1: Choose your Battle Button!";
        instructs[1] = "Player 2: Choose your Battle Button!";
        instructs[2] = "Player 3: Choose your Battle Button!";
        instructs[3] = "Player 4: Choose your Battle Button!";

    }

    void Awake()
    {
        DontDestroyOnLoad(this);

    }



    public void NumOfPlayers(int i)
    {
        switch (i)
        {
            case 2:
                num = 2;
                break;

            case 3:
                num = 3;
                break;

            case 4:
                num = 4;
                break;

            default:

                break;
        }
        StartCoroutine("AssignKeys");
    }



    public IEnumerator AssignKeys()
    {
     
        int i = 0;
        int x = 1;
        while (i < num)
        {
          
            txt[i].gameObject.SetActive(true);
            if (Input.anyKeyDown)
            {
                keys[i] = Input.inputString;
                txt[i].text = "Player " + x + ": " + keys[i];
                i++;
                x++;
                yield return null;

            }
            yield return null;
           
        }
        Application.LoadLevel(1);
    }

    /*
    “right shift”, “left shift”, “right ctrl”, “left ctrl”, “right alt”, “left alt”, “right cmd”, “left cmd”

    */

    void Update()
    {
    

    }
}
