using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyObj : MonoBehaviour
{
    public float deleteTime = 5.0f;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }


}