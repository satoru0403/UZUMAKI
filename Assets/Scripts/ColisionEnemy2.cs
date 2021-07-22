using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ColisionEnemy2 : MonoBehaviour
{
    public GameObject EnemyPrefab;

    void Start()
    {
        // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
        GameObject EnemyGenerator2 = Instantiate(EnemyPrefab) as GameObject;
    }

    // 当たり判定
    void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Result");
        }
    }

}
