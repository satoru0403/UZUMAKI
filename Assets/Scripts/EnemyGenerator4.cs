using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyGenerator4 : MonoBehaviour
{
    //敵プレハブ
    public GameObject enemyPrefab;
    //時間間隔の最小値
    public float minTime = 6f;
    //時間間隔の最大値
    public float maxTime = 7f;
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
    //敵生成時間間隔
    private float interval;
    //トータル用の時間
    private float spawnTime = 0f;
    //経過時間
    private float totaltime = 0f;



    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        totaltime += Time.deltaTime;
        spawnTime += Time.deltaTime;

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (spawnTime > interval)
        {
            //enemyをインスタンス化する(生成する)
            GameObject enemy = Instantiate(enemyPrefab);
            //生成した敵の位置をランダムに設定する
            enemy.transform.position = GetRandomPosition();
            //経過時間を初期化して再度時間計測を始める
            spawnTime = 0f;
            if (totaltime >= 160.0f)
            {
                minTime = 1f;
                maxTime = 2f;
                interval = GetRandomTime();
                Debug.Log("スピードが速くなった");
            }
            else if (totaltime >= 90.0f)
            {
                minTime = 2f;
                maxTime = 4f;
                //次に発生する時間間隔を決定する
                interval = GetRandomTime();
                Debug.Log("タンスノーマルスピード");
            }
            else if (totaltime >= 60.0f)
            {
                minTime = 4f;
                maxTime = 7f;
                //次に発生する時間間隔を決定する
                interval = GetRandomTime();
                Debug.Log("タンスノーマルスピード");
            }
            else if (totaltime >= 30.0f)
            {
                minTime = 5f;
                maxTime = 6f;
                //次に発生する時間間隔を決定する
                interval = GetRandomTime();
                Debug.Log("タンスノーマルスピード");
            }


        }
    }

    //ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    //ランダムな位置を生成する関数
    private Vector3 GetRandomPosition()
    {
        //それぞれの座標をランダムに生成する
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3型のPositionを返す
        return new Vector3(x, y, z);
    }
}