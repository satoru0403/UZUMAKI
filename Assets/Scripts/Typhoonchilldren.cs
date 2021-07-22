using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Typhoonchilldren : MonoBehaviour
{
    //カウントアップ
    private float countup = 0.0f;

    void Update()
    {
        //時間をカウントする
        countup += Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (countup <= 15.0f)
        {
            if (collision.gameObject.tag == ("Player"))
            {
                SceneManager.LoadScene("ResultD");
            }
        }

        if (countup >= 16.0f)
        {
            if (collision.gameObject.tag == ("Player"))
            {
                SceneManager.LoadScene("ResultC");
            }
        }

        if (countup >= 31.0f)
        {
            if (collision.gameObject.tag == ("Player"))
            {
                SceneManager.LoadScene("ResultB");
            }
        }

        if (countup >= 46.0f)
        {
            if (collision.gameObject.tag == ("Player"))
            {
                SceneManager.LoadScene("ResultA");
            }
        }
    }

}
