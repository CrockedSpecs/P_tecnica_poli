using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteCubes : MonoBehaviour
{

    public int secondsToDestroy;
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(destroyCube());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameManager.Instance.GetPoints();
    }
    IEnumerator destroyCube()
    {
        yield return new WaitForSeconds(secondsToDestroy);
        gameObject.SetActive(false);
        GameManager.Instance.restPoints();
    }
}
