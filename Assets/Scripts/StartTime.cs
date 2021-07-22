using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartTime : MonoBehaviour
{
	public GameObject stime1;
	public GameObject stime2;
	public GameObject stime3;
    public GameObject start;
    private float counttime = 3.0f;

    void Start()
    {
        start.SetActive(false);
        stime1.SetActive(false);
        stime2.SetActive(false);
        stime3.SetActive(false);
    }

    void Update()
    {
        counttime -= Time.deltaTime;
    }

    void FixedUpdate()
    {
        if(counttime < 3)
        {
            stime3.SetActive(true);
            if (counttime < 2)
            {
                stime3.SetActive(false);
                stime2.SetActive(true);
            }
            if (counttime < 1)
            {
                stime2.SetActive(false);
                stime1.SetActive(true);
            }
            if (counttime < 0)
            {
                stime1.SetActive(false);
                start.SetActive(true);
            }
            if (counttime < -1)
            {
                start.SetActive(false);
            }
        }

    }
}