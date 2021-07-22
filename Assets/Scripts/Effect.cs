using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public GameObject effect;
    private float Starttime = 3;
    void Start()
    {
        effect.SetActive(false);
    }

    void Update()
    {
        Starttime -= Time.deltaTime;
    }

    void FixedUpdate()
    {
        {
            if (Starttime < 0)
            {
                if (Input.GetButton("Dash"))
                {
                    effect.SetActive(true);
                }
                else
                {
                    effect.SetActive(false);
                }
            }
        }
    }
}
