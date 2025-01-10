using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Points = 0;
    public TextMeshProUGUI pointsText;

    private static GameManager instance;
    public static GameManager Instance {  get { return instance; } }


    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        pointsText.text = ("Points: "+ Points);
    }

    public void GetPoints()
    {
        Points += 10;
    }

    public void restPoints()
    {
        Points -= 5;
    }
}
