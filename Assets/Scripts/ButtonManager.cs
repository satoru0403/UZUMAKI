using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    static bool[] clearStages = new bool[3];
    
    public GameObject stage2;
    public GameObject stage3;
    public GameObject rock2;
    public GameObject rock3;
    void Start()
    {
        stage2.SetActive(false);
        stage3.SetActive(false);
        rock2.SetActive(false);
        rock3.SetActive(false);
    }

    public void S2()
    {
        stage2.SetActive(false);
    }

    public void S3()
    {
        stage3.SetActive(false);
    }

    public void R2()
    {
        rock2.SetActive(false);
    }

    public void R3()
    {
        rock3.SetActive(false);
    }
}
