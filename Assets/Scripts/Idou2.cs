using UnityEngine;
using System.Collections;

public class Idou2 : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeedX = 5;
    public float moveSpeedY = 5;


    void Start()
    {

        //GetComponentの処理をキャッシュしておく
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float speedy = 0;
        float speedx = 0;
        if (gameObject.transform.forward.y == 0)
        {
            speedy = moveSpeedY;
        }
        if (gameObject.transform.forward.x == 0)
        {
            speedx = moveSpeedX;
        }
        //velocity: 速度
        //X方向へmoveSpeed分移動させる
        rb.velocity = new Vector2(speedy, rb.velocity.y);
        rb.velocity = new Vector2(speedx, rb.velocity.x);

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
