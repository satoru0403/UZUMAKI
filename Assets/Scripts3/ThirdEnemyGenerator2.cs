using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ThirdEnemyGenerator2 : MonoBehaviour
{
    [Serializable]
    public class SpawnKey
    {
        public float startTime = 0;
        public float endTime = 0;
    }
    [SerializeField]
    SpawnKey[] spawnKeys = null;

    //敵プレハブ
    public GameObject enemyPrefab;
    //X座標の最小値
    public float xMinPosition = 0f;
    //X座標の最大値
    public float xMaxPosition = 0f;
    //Y座標の最小値
    public float yMinPosition = -5f;
    //Y座標の最大値
    public float yMaxPosition = 5f;
    //Z座標の最小値
    public float zMinPosition = 10f;//使ってない
    //Z座標の最大値
    public float zMaxPosition = 20f;//使ってない

    int enemyCount = 0;

    //private float MinTime = 55.00f;
    //private float MaxTime = 54.99f;
    //経過時間
    private float totaltime = -3.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        totaltime += Time.deltaTime;
        if (totaltime >= 5 && totaltime <= 5.5f && enemyCount <= 0)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 9 && totaltime <= 9.5f && enemyCount <= 1)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 12 && totaltime <= 12.5f && enemyCount <= 2)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 15 && totaltime <= 15.5f && enemyCount <= 3)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 25 && totaltime <= 25.5f && enemyCount <= 4)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 26 && totaltime <= 26.5f && enemyCount <= 5)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 27 && totaltime <= 27.5f && enemyCount <= 6)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 31 && totaltime <= 31.5f && enemyCount <= 7)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 37 && totaltime <= 37.5f && enemyCount <= 8)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 41 && totaltime <= 41.5f && enemyCount <= 9)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 44 && totaltime <= 44.5f && enemyCount <= 10)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 48 && totaltime <= 48.5f && enemyCount <= 11)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 53 && totaltime <= 53.5f && enemyCount <= 12)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 54 && totaltime <= 54.5f && enemyCount <= 13)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 57 && totaltime <= 57.5f && enemyCount <= 14)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 61 && totaltime <= 61.5f && enemyCount <= 15)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 66 && totaltime <= 66.5f && enemyCount <= 16)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 67 && totaltime <= 67.5f && enemyCount <= 17)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 72 && totaltime <= 72.5f && enemyCount <= 18)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 75 && totaltime <= 75.5f && enemyCount <= 19)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 76 && totaltime <= 76.5f && enemyCount <= 20)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 84 && totaltime <= 84.5f && enemyCount <= 21)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 87 && totaltime <= 87.5f && enemyCount <= 22)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 93 && totaltime <= 93.5f && enemyCount <= 23)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 94 && totaltime <= 94.5f && enemyCount <= 24)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 105 && totaltime <= 105.5f && enemyCount <= 25)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 107 && totaltime <= 107.5f && enemyCount <= 26)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 112 && totaltime <= 112.5f && enemyCount <= 27)
        {
            SpawnEnemy();
        }
        else if (totaltime >= 115 && totaltime <= 115.5f && enemyCount <= 28)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        //enemyをインスタンス化する(生成する)
        GameObject enemy = Instantiate(enemyPrefab);
        //生成した敵の位置をランダムに設定する
        enemy.transform.position = GetRandomPosition();
    }

    //ランダムな位置を生成する関数
    private Vector3 GetRandomPosition()
    {
        //それぞれの座標をランダムに生成する
        float x = UnityEngine.Random.Range(xMinPosition, xMaxPosition);
        float y = UnityEngine.Random.Range(yMinPosition, yMaxPosition);
        float z = UnityEngine.Random.Range(zMinPosition, zMaxPosition);//飾り
        enemyCount++;

        //Vector3型のPositionを返す
        return new Vector3(x, y, z);
    }
}