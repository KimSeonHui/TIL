using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public bool isSuccess;
    public int count;
    public LayerMask layerMask;
    public Camera myCam;
    public Image selectImage;
    public Image isRightImage;
    public Image[] lifeImage;

    void Start()
    {
        isSuccess = false;
        count = 0;
        selectImage.gameObject.SetActive(false);
        isRightImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, myCam.transform.forward * 100f, Color.green);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, myCam.transform.forward, out hit, 100f, layerMask))
        {
            selectImage.gameObject.SetActive(true);
            selectImage.transform.position = hit.collider.gameObject.transform.position + new Vector3(0f, 3.3f, 0f);

            if(hit.collider.GetComponent<NPCMove>() != null)
            {
                hit.collider.GetComponent<NPCMove>().moveSpeed = 0f;
            }
           
            if (Input.GetKeyDown(KeyCode.F))
            {
                if(hit.collider != null)
                {
                    Debug.Log($"hit.name : {hit.collider.name}");
                    if (hit.collider.CompareTag("HOME") || hit.collider.CompareTag("OWNER"))
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                        isRightImage.transform.position = hit.collider.gameObject.transform.position + new Vector3(0f, 3.3f, 0f);
                        isRightImage.gameObject.SetActive(true);
                        selectImage.gameObject.SetActive(false);
                        Invoke("ImageFalse", 2f);
                        lifeImage[count].gameObject.SetActive(false);
                    }
                }
                else
                {
                    lifeImage[count].gameObject.SetActive(false);
                }                               
                count++;
            }

        }
        else
        {
            selectImage.gameObject.SetActive(false);
        }   
    }

    private void ImageFalse()
    {
        isRightImage.gameObject.SetActive(false);
    }    
}
