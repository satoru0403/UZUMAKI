using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace uzumaki
{
    public class EnemyGenerator : MonoBehaviour
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
            if (totaltime >= 2 && totaltime <= 2.5f && enemyCount <= 0)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 4 && totaltime <= 4.5f && enemyCount <= 1)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 8 && totaltime <= 8.5f && enemyCount <= 2)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 10 && totaltime <= 10.5f && enemyCount <= 3)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 12 && totaltime <= 12.5f && enemyCount <= 4)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 14 && totaltime <= 14.5f && enemyCount <= 5)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 16 && totaltime <= 16.5f && enemyCount <= 6)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 21 && totaltime <= 21.5f && enemyCount <= 7)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 25 && totaltime <= 25.5f && enemyCount <= 8)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 28 && totaltime <= 28.5f && enemyCount <= 9)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 30 && totaltime <= 30.5f && enemyCount <= 10)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 32 && totaltime <= 32.5f && enemyCount <= 11)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 35 && totaltime <= 35.5f && enemyCount <= 12)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 36 && totaltime <= 36.5f && enemyCount <= 13)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 41 && totaltime <= 41.5f && enemyCount <= 14)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 46 && totaltime <= 46.5f && enemyCount <= 15)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 47 && totaltime <= 47.5f && enemyCount <= 16)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 50 && totaltime <= 50.5f && enemyCount <= 17)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 52 && totaltime <= 52.5f && enemyCount <= 18)
            {
                SpawnEnemy();
            }
            else if (totaltime >= 55 && totaltime <= 55.5f && enemyCount <= 19)
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
}
