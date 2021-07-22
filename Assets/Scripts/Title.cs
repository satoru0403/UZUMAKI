using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            GetComponent<Renderer>().material.color = Color.black;
            SceneManager.LoadScene("Game");
        }
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Renderer>().material.color = Color.black;
            SceneManager.LoadScene("Game");
        }
    }
}
