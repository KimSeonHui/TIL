using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trace : MonoBehaviour
{
    public Image[] traceImage;
    public GameObject skillImage;
    private List<GameObject> traceImagePositionList = new List<GameObject>();
    private bool getKeyE;

    void Start()
    {
        getKeyE = false;

        for (int i = 0; i < traceImage.Length; i++)
        {            
            traceImage[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            getKeyE = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TRACE"))
        {
            traceImagePositionList.Add(other.gameObject);
            Debug.Log($"list에 추가! : {other.name}");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (getKeyE && other.CompareTag("TRACE"))
        {
            getKeyE = false;
            skillImage.SetActive(false);

            int end = 0;

            if (traceImage.Length < traceImagePositionList.Count)
            {
                end = traceImage.Length;
            }
            else
            {
                end = traceImagePositionList.Count;
            }

            for (int i = 0; i < end; i++)
            {
                traceImage[i].gameObject.SetActive(true);
                traceImage[i].sprite = other.GetComponent<Image>().sprite;

                if (traceImagePositionList[i] != null)
                {
                    traceImage[i].transform.position = traceImagePositionList[i].transform.position + new Vector3(0f, 0.1f, 0f);
                }
            }
            Invoke("UnssignImage", 5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TRACE"))
        {
            traceImagePositionList.Remove(other.gameObject);
        }
    }

    private void UnssignImage()
    {
        for (int i = 0; i < traceImage.Length; i++)
        {
            traceImage[i].gameObject.SetActive(false);
        }
        skillImage.SetActive(true);
    }
}
