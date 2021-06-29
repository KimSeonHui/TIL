using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePath : MonoBehaviour
{
    public GameObject tracePrefab;
    private int prefabCount;

    void Start()
    {
        prefabCount = 0;
        StartCoroutine(CreatePrefab());
    }

    IEnumerator CreatePrefab()
    {
        while(prefabCount < 5)
        {
            GameObject traceInstance = Instantiate(tracePrefab, transform.position + new Vector3(0f, 0.1f, 0f), transform.rotation);
            Destroy(traceInstance, 15f);

            prefabCount += 1;

            if(prefabCount == 5)
            {
                prefabCount = 0;
            }

            yield return new WaitForSeconds(3);
        }

    }
}
