using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public void OnClickRetryButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}
