using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private List <float> CameraMoveTimes;
    public float MoveCount;
    [SerializeField]
    private List<Camera> cameras;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CameraMoves());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) {
            Time.timeScale = 5.0f;
        }
        else
        {
            Time.timeScale = 1;
        }
        
    }

    private IEnumerator CameraMoves()
    {
        yield return StartCoroutine(CameraMove1());
    }

    private IEnumerator CameraMove1()
    {
        while (CameraMoveTimes[0] > MoveCount)
        {
            MoveCount += Time.deltaTime;
            transform.position += Vector3.left * Time.deltaTime / 5;

            yield return null;

        }
        MoveCount = 0;
    }
    public IEnumerator CameraMove2()
    {
        cameras[0].gameObject.SetActive(true);
        while (CameraMoveTimes[1] > MoveCount)
        {
            MoveCount += Time.deltaTime;
            cameras[0].transform.position += new Vector3(0.25f,0.1f,0) * Time.deltaTime;
            cameras[0].transform.localRotation *= Quaternion.Euler(0, 3f * Time.deltaTime, 0);


            yield return null;

        }
        cameras[0].gameObject.SetActive(false);
    }
    public IEnumerator CameraMove3()
    {
        cameras[1].gameObject.SetActive(true);
        while (CameraMoveTimes[2] > MoveCount)
        {
            MoveCount += Time.deltaTime;
            cameras[1].transform.position += new Vector3(0, 0, 3) * Time.deltaTime;


            yield return null;

        }
    }
    public IEnumerator CameraMove4()
    {
        cameras[1].gameObject.SetActive(true);
        while (CameraMoveTimes[3] > MoveCount)
        {
            MoveCount += Time.deltaTime;
            cameras[1].transform.position += new Vector3(0, 0.5f, 0) * Time.deltaTime;


            yield return null;

        }
    }

}
