using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    CameraMove cameraMove;

    [SerializeField]
    private List<Text> XmasTexts;
    [SerializeField]
    private Image BackGround;
    [SerializeField]
    private Image BlackOut;

    [SerializeField]
    private List<GameObject> Lights;
    void Start()
    {
        cameraMove = FindObjectOfType<CameraMove>();
        StartCoroutine(Texts());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Texts()
    {
        yield return StartCoroutine(Text1());
        yield return StartCoroutine(Text2());
        yield return StartCoroutine(Text3());
    }


    IEnumerator Text1()
    {

        yield return new WaitForSeconds(1f);
        while (XmasTexts[0].color.a < 1)
        {
            if (BackGround.color.a < 0.5f)
            {
                BackGround.color += new Color(0, 0, 0, Time.deltaTime / 3);
            }
            XmasTexts[0].color += new Color(0,0,0, Time.deltaTime / 3);
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        while (BlackOut.color.a < 1)
        {
            
            BlackOut.color += new Color(0, 0, 0, Time.deltaTime / 3);
            yield return null;
        }
        BackGround.color = new Color(0, 0, 0, 0);
        XmasTexts[0].gameObject.SetActive(false);
        Lights[0].SetActive(false);
        Lights[1].SetActive(true);
        cameraMove.StartCoroutine(cameraMove.CameraMove2());

        cameraMove.MoveCount = 0;
    }
    IEnumerator Text2()
    {
        while (BlackOut.color.a > 0)
        {
            if (BackGround.color.a < 0.5f)
            {
                //BackGround.color += new Color(0, 0, 0, Time.deltaTime / 3);
                XmasTexts[1].color += new Color(0, 0, 0, Time.deltaTime);
                yield return null;
            }
            BlackOut.color -= new Color(0, 0, 0, Time.deltaTime / 1.5f);
            yield return null;
        }
        while (BlackOut.color.a < 1)
        {

            BlackOut.color += new Color(0, 0, 0, Time.deltaTime / 3);
            yield return null;
        }
        XmasTexts[1].gameObject.SetActive(false);
        Lights[1].SetActive(false);
        Lights[0].SetActive(true);
        cameraMove.StartCoroutine(cameraMove.CameraMove3());
        cameraMove.MoveCount = 0;
        yield return null;
    }
    IEnumerator Text3()
    {
        while (BlackOut.color.a > 0)
        {
            if (BackGround.color.a < 0.5f)
            {
                XmasTexts[2].color += new Color(0, 0, 0, Time.deltaTime);
                yield return null;
            }
            BlackOut.color -= new Color(0, 0, 0, Time.deltaTime / 1.5f);
            yield return null;
        }
        while (BlackOut.color.a < 1)
        {

            BlackOut.color += new Color(0, 0, 0, Time.deltaTime / 3);
            yield return null;
        }

        yield return null;
    }
    IEnumerator Text4()
    {
        while (BlackOut.color.a > 0)
        {
            if (BackGround.color.a < 0.5f)
            {
                XmasTexts[3].color += new Color(0, 0, 0, Time.deltaTime);
                yield return null;
            }
            BlackOut.color -= new Color(0, 0, 0, Time.deltaTime / 1.5f);
            yield return null;
        }
        while (BlackOut.color.a < 1)
        {

            BlackOut.color += new Color(0, 0, 0, Time.deltaTime / 3);
            yield return null;
        }

        yield return null;
    }
}
