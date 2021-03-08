using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    private SpriteRenderer theSR;
    
    public int currentHealth, maxHealth;

    public float invincibleLenght;
    private float invincibleCounter;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
    }


    void Update()
    {
        if (invincibleCounter > 0)
        {
            invincibleCounter -= Time.deltaTime;

            if (invincibleCounter <= 0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }
        }
    }

    public void DealDamage()
    {
        if (invincibleCounter <= 0)
        {
            currentHealth--;

            if (currentHealth <= 0)
            {
                currentHealth = 0;

                gameObject.SetActive(false);
            }
            else
            {
                invincibleCounter = invincibleLenght;

                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 0.5f);
                
                PlayerController.instance.KnockBack();
            }

            UIController.instance.UpdateHealthDisplay();
        }
    }
}
