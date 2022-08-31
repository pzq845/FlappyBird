using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class PipeManager : MonoBehaviour
{
    private Vector3 PipeGeneratePoint;
    public GameObject Pipe;

    private void Awake()
    {
        Transform transform = GameObject.FindGameObjectWithTag("Generate").transform;
        PipeGeneratePoint = transform.position;
        //StartCoroutine("GeneratePipe");
        StartCoroutine(generatePipe());
    }


    IEnumerator generatePipe()
    {
        while (true)
        {
            float y = Random.Range(-3f, 3.5f);
            Debug.Log(y);
            PipeGeneratePoint = new Vector3(PipeGeneratePoint.x, y, PipeGeneratePoint.z);
            Instantiate(Pipe, PipeGeneratePoint, Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
