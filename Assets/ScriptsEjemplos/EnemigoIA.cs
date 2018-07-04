using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoIA : MonoBehaviour
{

    // Use this for initialization

    public Transform player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);

        if (Vector3.Distance(player.position, this.transform.position) < 120  && angle < 45)
        {
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                        Quaternion.LookRotation(direction), 0.1f);

            if (direction.magnitude > 5)
            {
                this.transform.Translate(0, 0, 0.6f);
            }

        }


    }

}