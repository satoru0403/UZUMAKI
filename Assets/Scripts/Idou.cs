using UnityEngine;
using System.Collections;

public class Idou : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 5;


    void Start()
    {

        //GetComponentの処理をキャッシュしておく
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float speed = 0;
        if (gameObject.transform.forward.y == 0)
        {
            speed = moveSpeed;
        }

        //velocity: 速度
        //X方向へmoveSpeed分移動させる
        rb.velocity = new Vector2(speed, rb.velocity.y);

    }

    void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}
//velocity: 速度
//X方向へmoveSpeed分移動させる
//rb.velocity = new Vector2(speed, rb.velocity.y);
