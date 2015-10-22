using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float flailing = 300;
    public float thrust = 150;
    public float maxThrust = 400;
    public float hold = 0.01f;
    public bool spin = true;
    public float chargeup = 10;
    public bool attack = true;
    public string actionKey = "w";
    public GameObject sprintfx;

    public enum CharType{
        spear,
        spearshield,
        swordshield,
        sword,
        shieldy,
        teleport


    }
    public CharType character;

    public void SetStats() {
        switch (character)
        {
            case CharType.spear:
                hold = 0.2f;
                break;
            case CharType.spearshield:
                flailing = 250;
                break;
            case CharType.swordshield:
                flailing = 300;
                break;
            case CharType.sword:
                flailing = 325;
                break;
            case CharType.shieldy:
                flailing = 125;

                break;
            case CharType.teleport:
                break;
            default:
                break;
        }

    }


    // Use this for initialization
    void Start()
    {
        SetStats();
        StartCoroutine("Spinner");
    }


    IEnumerator Spinner()
    {
        while (true)
        {

            if (Input.GetKey(actionKey) != true && spin == true)
            {
               transform.RotateAround(transform.position, Vector3.up, -flailing * Time.deltaTime);
            }
            yield return null;
        }

    }
    IEnumerator Charger()
    {
        while (Input.GetKey(actionKey) && thrust < maxThrust)
        {
            yield return new WaitForSeconds(0.000000000001f);
            thrust += chargeup;
            
        }

        //Instantiate(sprintfx, transform.position, transform.rotation);

        GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
        if (thrust < maxThrust) {
            Debug.Log("Starting hold");
            StartCoroutine("Hold");
        }
        thrust = 200;

    }

    IEnumerator Hold() {
        spin = false;
        attack = false;
        yield return new WaitForSeconds(hold);
        spin = true;
        attack = true;
    }

    public void Attack() {
        if (Input.GetKeyDown(actionKey) && attack == true)
        {
            StartCoroutine("Charger");
        }

    }
    // Update is called once per frame
    void Update()

    {

        Attack();
        

    }
}
