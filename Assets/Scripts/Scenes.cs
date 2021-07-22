using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    private int keypoint2  = 0;
    private int keypoint3  = 0;
    //private bool rule;
    [SerializeField]
    Button selectedButton;

    // Use this for initialization
    void Start()
    {
        selectedButton.Select();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

      //if (Input.GetButtonDown("StageSelect"))
      //  {
      //       SceneManager.LoadScene("Stage Select");
      //  }


      //  if (Input.GetButtonDown("Manual"))
      //  {
      //      SceneManager.LoadScene("Manual");
      //      rule = true;
      //  }

      //  if (rule)
      //  {
      //      if (Input.GetButtonDown("Manual2"))
      //      {
      //          SceneManager.LoadScene("Manual2");
      //      }
      //  }




    }

    //追加した
    //ボタンを押した時の処理
    public void TitleGo()
    {
        SceneManager.LoadScene("Title");
    }
    public void ManualGo()
    {
        SceneManager.LoadScene("Manual");
    }
    public void Manual2Go()
    {
        SceneManager.LoadScene("Manual2");
    }
    public void Manual3Go()
    {
        SceneManager.LoadScene("Manual3");
    }
    public void SelectGo()
    {
        SceneManager.LoadScene("Stage Select");
    }

    public void Stage1()
    {
        SceneManager.LoadScene("Game");
    }

    public void Stage2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void Stage3()
    {
            SceneManager.LoadScene("Game3");
    }

    public void Addpoint2()
    {
        keypoint2 += 1;
    }

    public void Addpoint3()
    {
        keypoint3 += 1;
    }
}
