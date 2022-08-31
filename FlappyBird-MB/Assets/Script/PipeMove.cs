using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class PipeMove : MonoBehaviour
{
    public BirdController player;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<BirdController>();
        Destroy(this.gameObject, 12f);
    }
    private void Update()
    {
        transform.position += -transform.right * player.fly_speed;
    }

}
