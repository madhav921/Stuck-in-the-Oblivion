using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIFE : MonoBehaviour
{

    // public GameObject player;
	public int maxHealth = 100;
	public int OxygenHealth;
	public int Health;

	public HealthBar healthBar;
	public OxygenBar oxygen;
    public Refilling refill;

    void Start()
    {
		OxygenHealth = maxHealth*100;
        Health = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		oxygen.SetMaxHealth(maxHealth*100);
    }

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(11,500);
		}
        else
        {
            TakeDamage(10,500);
        }
    }
	void TakeDamage(int damage,int regen)
	{
        if(oxygen.slider.value == 0 && Input.GetKeyDown(KeyCode.Space))
        {
		    Health -= damage;
		    healthBar.SetHealth(Health);
        }
        if(oxygen.slider.value != 0 && Input.GetKeyDown(KeyCode.Space))
        {
            damage = 250;
            OxygenHealth -= damage;
            oxygen.SetHealth(OxygenHealth);
        }
        if (!refill.m_IsPlayerAtPump)
        {
		    OxygenHealth -= damage;
            oxygen.SetHealth(OxygenHealth);
        }
        else if(refill.m_IsPlayerAtPump && OxygenHealth<=10000)
        {
            OxygenHealth += regen ;
            oxygen.SetHealth(OxygenHealth);
        }
	}
}
