using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float fly_up_speed = 2;
    public float fly_speed = 2;
    private Rigidbody2D rigidbody;
    public Text scoreText;
    public Image teachUI;
    public float routateAngle = 2;
    public bool isAilve = true;
    public GameObject endGameUI;

    private int  score = 0;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        StartCoroutine(setScore());
        Invoke("setTeachUI", 5);
    }
    private void Update()
    {
        if (isAilve)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody.velocity = new Vector2(0,1) * fly_up_speed;
            }
            transform.DORotateQuaternion(Quaternion.Euler(0, 0, rigidbody.velocity.y * routateAngle),0.3f);
            //transform.rotation = Quaternion.Euler(0, 0, rigidbody.velocity.y* routateAngle);
        }
    }
    IEnumerator setScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            if (!isAilve)
            {
                break;
            }
            score += 1;
            scoreText.text = score.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isAilve = false;
        endGameUI.SetActive(true);
        endGameUI.GetComponent<UIManager>().showUI();
    }

    private void setTeachUI()
    {
        teachUI.enabled = false;
    }
}
