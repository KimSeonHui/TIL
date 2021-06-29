using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smell : MonoBehaviour
{
    private float distance;
    public Image[] smellImage;
    private int imageCount;
    
    void Start()
    {
        distance = 0f;
        imageCount = 0;

        for(int i = 0; i < smellImage.Length; i++)
        {
            smellImage[i].gameObject.SetActive(false);
        }      
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("SMELL"))
        {
            distance = Vector3.Distance(other.transform.position, transform.position);           

            if (distance >= 7.5f)
            {
                imageCount = 1;
                AssignImage(other.gameObject);
            }
            else if (distance >= 4f && distance < 7.5f)
            {
                imageCount = 3;
                AssignImage(other.gameObject);
            }
            else if (distance > 0 && distance < 4f)
            {
                imageCount = 5;
                AssignImage(other.gameObject);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        for(int i = 0; i < smellImage.Length; i++)
        {
            smellImage[i].gameObject.SetActive(false);
        }        
    }

    private void AssignImage(GameObject other)
    {
        for (int i = 0; i < smellImage.Length; i++)
        {
            if (i < imageCount)
            {
                smellImage[i].gameObject.SetActive(true);
                smellImage[i].sprite = other.GetComponent<Image>().sprite;
            }
        }
    }
}
