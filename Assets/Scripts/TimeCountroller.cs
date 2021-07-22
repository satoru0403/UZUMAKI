using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCountroller : MonoBehaviour
{

    GameObject timerText;
    float time = 60f;
    float sctime = 0.0f;
    private Scenes keypoint;
    private ButtonManager keyflag;

    // Start is called before the first frame update
    void Start()
    {
        keyflag = GetComponent<ButtonManager>();
        keypoint = GetComponent<Scenes>();
        timerText = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        sctime += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if(sctime > 3)
        {
            time -= Time.deltaTime;
            timerText.GetComponent<Text>().text =
            time.ToString("F1");

            if (time <= 0f)
            {
                SceneManager.LoadScene("ResultS");
                    keyflag.stage2.SetActive(false);
                    keyflag.rock2.SetActive(false);
                    keypoint.Addpoint2();
            }
        }
    }
}

