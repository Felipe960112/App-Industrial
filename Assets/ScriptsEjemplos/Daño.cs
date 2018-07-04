using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    public bool isDamaging;
    public float damage = 10; 

    private void OnTriggerStay(Collider Enemy1)
    {
        if (Enemy1.tag == "Player")
        {
            Enemy1.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
        }

        
    }


}