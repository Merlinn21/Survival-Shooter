using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : PowerUP
{
    private PlayerHealth hp;
    private Slider sliderUpdate;

    private void Start()
    {
        hp = GameObject.Find("Player").GetComponent<PlayerHealth>();
        sliderUpdate = GameObject.Find("HealthSlider").GetComponent<Slider>();
    }
    public override void Powers()
    {
        if (hp.currentHealth < 100)
            hp.currentHealth += 25; 

        if (hp.currentHealth > 100)
            hp.currentHealth = 100;
        sliderUpdate.value = hp.currentHealth;
        Destroy(this.gameObject);
    }

}
