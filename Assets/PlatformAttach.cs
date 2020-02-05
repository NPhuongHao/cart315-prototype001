using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    // source: https://www.youtube.com/watch?v=rO19dA2jksk
    public GameObject Player;

    public GameObject Charge;
    public GameObject Unscaled;

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject == player || other.gameObject.GetComponent<Rigidbody>() != null)
        if (other.gameObject == Player || other.gameObject == Charge)
        {
            //object2.tranform.parent = object1.transform
            other.gameObject.transform.parent = Unscaled.transform;

            //player.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player || other.gameObject == Charge)
        {
            other.gameObject.transform.parent = null;
        }
    }

}
