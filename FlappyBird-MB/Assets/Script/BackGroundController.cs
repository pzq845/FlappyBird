using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class BackGroundController : MonoBehaviour
{
    private Vector3 startPos;

    private BirdController player;
    private void Awake()
    {
        startPos = transform.position;
        player = GameObject.FindWithTag("Player").GetComponent<BirdController>();
    }

    private void Update()
    {
        if (transform.position.x < -5.37)
        {
            transform.position = startPos;
        }

        transform.position -= new Vector3(player.fly_speed, 0, 0);

    }


}
