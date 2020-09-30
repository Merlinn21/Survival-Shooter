using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMG : PowerUP
{
    private PlayerShooting dmg;
    private MeshRenderer showOBJ;
    private CapsuleCollider colliderDisable;

    private void Start()
    {
        dmg = GameObject.Find("GunBarrelEnd").GetComponent<PlayerShooting>();
        showOBJ = this.gameObject.GetComponent<MeshRenderer>();
        colliderDisable = this.gameObject.GetComponent<CapsuleCollider>();
    }

    public override void Powers()
    {
        dmg.damagePerShot *= 2; 
        showOBJ.enabled = !showOBJ.enabled; 
        colliderDisable.enabled = !colliderDisable.enabled; 
        Invoke("resetDMG", 5); 
    }

    private void resetDMG()
    {
        dmg.damagePerShot /= 2;
        Destroy(this.gameObject); 
    }
}
