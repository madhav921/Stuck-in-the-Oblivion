using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class Refilling : MonoBehaviour
{
    // int Health = 10000;

    public GameObject player;
    public OxygenBar oxygen;
    public bool m_IsPlayerAtPump = false;
    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Collided");
        if (other.gameObject == player)
        {
            m_IsPlayerAtPump = true;
        }
        // if(m_IsPlayerAtPump)
        // oxygen.SetHealth(Health);
    }
    void OnTriggerExit (Collider other)
    {
        Debug.Log("Exit");
        Debug.Log(m_IsPlayerAtPump);
        m_IsPlayerAtPump = false;
    }
  
}
