using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdTyphoon : MonoBehaviour
{
    private float step_time = 0.0f;    // 経過時間カウント用

    public float rotation_speed = 2.0f; // 回転速度

    public int difficultyLevel = 7;

    // Update is called once per frame
    void Update()
    {
        // 回転速度分回す
        transform.Rotate(0, 0, -this.rotation_speed);

        // サイズ変更
        // 経過時間をカウント
        step_time += Time.deltaTime;

        if (step_time >= 90.0f)
        {
            transform.localScale -= new Vector3(0.0002f, 0.0002f, 0);
        }
        if (step_time >= 120.0f)
        {
            transform.localScale += new Vector3(0.0002f, 0.0002f, 0);
        }
    }
}