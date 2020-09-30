using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MSPD : PowerUP
{
    private PlayerMovement mSpeed;
    private MeshRenderer showOBJ;
    private CapsuleCollider colliderDisable;

    private void Start()
    {
        mSpeed = GameObject.Find("Player").GetComponent<PlayerMovement>();
        showOBJ = this.gameObject.GetComponent<MeshRenderer>();
        colliderDisable = this.gameObject.GetComponent<CapsuleCollider>();
    }
    public override void Powers()
    {
        mSpeed.speed *= 2;
        showOBJ.enabled = !showOBJ.enabled;
        colliderDisable.enabled = !colliderDisable.enabled;
        Invoke("resetSpeed", 5);
    }

    private void resetSpeed()
    {
        mSpeed.speed /= 2;
        Destroy(this.gameObject);
    }
}
