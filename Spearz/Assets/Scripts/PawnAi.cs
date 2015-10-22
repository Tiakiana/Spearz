using UnityEngine;
using System.Collections;

public class PawnAi : MonoBehaviour {
    RaycastHit rc;
    bool spin = true;
    PlayerControl pc;
	void Start () {
      //  StartCoroutine("Spinner");
        StartCoroutine("LookForEnemy");
        pc = GetComponent<PlayerControl>();

    }
    /*
    IEnumerator Spinner()
    {
        while (true)
        {

            if (spin == true)
            {
                transform.RotateAround(transform.position, Vector3.up, -350 * Time.deltaTime);
            }
            yield return null;
        }

    }
    */
    IEnumerator LookForEnemy()
    {

        while (true)
        {
            if (Physics.Raycast(transform.position + transform.forward, transform.forward, out rc))
            {
                Debug.DrawLine(transform.position + transform.forward, rc.point, Color.cyan);

                Debug.Log(rc.collider.gameObject.tag);
                if (rc.collider.gameObject.tag == "Player")
                {
                    GetComponent<Rigidbody>().AddForce(transform.forward * pc.maxThrust);
                    yield return new WaitForSeconds(1.7f);


                }
            }
            yield return new WaitForSeconds(.01f);

        }

    }

  



    void Update () {
	
	}
}
