using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Powers();
    }

    public virtual void Powers()
    {
        //tidak ngapa - ngapain
    }
}
