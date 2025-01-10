using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubesPool : MonoBehaviour
{

    [SerializeField] private GameObject red;
    [SerializeField] private GameObject yellow;
    [SerializeField] private GameObject blue;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<GameObject> redList;
    [SerializeField] private List<GameObject> yellowList;
    [SerializeField] private List<GameObject> blueList;

    private static cubesPool instance;
    public static cubesPool Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AddCubesToPool(poolSize);
    }


    private void AddCubesToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject redCube = Instantiate(red);
            GameObject yellowCube = Instantiate(yellow);
            GameObject blueCube = Instantiate(blue);
            redCube.SetActive(false);
            yellowCube.SetActive(false);
            blueCube.SetActive(false);
            redList.Add(redCube);
            blueList.Add(blueCube);
            yellowList.Add(yellowCube);
            redCube.transform.parent = transform;
            yellowCube.transform.parent = transform;
            blueCube.transform.parent = transform;

        }
    }

    public GameObject RequestCube(int randomNumber)
    {
        if (randomNumber == 1)
        {
            for (int i = 0; i < yellowList.Count; i++)
            {
                if (!yellowList[i].activeSelf)
                {
                    yellowList[i].SetActive(true);
                    return yellowList[i];
                }
            }
        }
        else if (randomNumber == 2)
        {
            for (int i = 0; i < blueList.Count; i++)
            {
                if (!blueList[i].activeSelf)
                {
                    blueList[i].SetActive(true);
                    return blueList[i];
                }
            }
        }
        else if (randomNumber == 3)
        {
            for (int i = 0; i < redList.Count; i++)
            {
                if (!redList[i].activeSelf)
                {
                    redList[i].SetActive(true);
                    return redList[i];
                }
            }
        }
        return null;
    }
}
