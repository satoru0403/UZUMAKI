
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{



    public GameObject pointText;
    int point = 3;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        this.pointText.GetComponent<Text>().text =
            this.point.ToString();

        //this.time -= Time.deltaTime;
        //this.timerText.GetComponent<Text>().text =
        //    this.time.ToString("F1");
        //if ((time <= 0.0f) && (point <= -1))
        //{
        //    SceneManager.LoadScene("Finish-");
        //}
        //else if ((time <= 0.0f) && (point <= 150))
        //{
        //    SceneManager.LoadScene("Finish0-200");
        //}
        //else if ((time <= 0.0f) && (point <= 350))
        //{
        //    SceneManager.LoadScene("Finish250-400");
        //}
        //else if ((time <= 0.0f) && (point <= 550))
        //{
        //    SceneManager.LoadScene("Finish450-600");
        //}
        //else if ((time <= 0.0f) && (point <= 750))
        //{
        //    SceneManager.LoadScene("Finish650-800");
        //}
        //else if ((time <= 0.0f) && (point >= 800))
        //{
        //    SceneManager.LoadScene("Finish800-");

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            if (this.point == 0)
            {
                SceneManager.LoadScene("ResultA");
            }
            else
            {
                this.point -= 1;
            }
        }
    }
}