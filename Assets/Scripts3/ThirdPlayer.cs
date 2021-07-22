using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class ThirdPlayer : MonoBehaviour
{
    public AudioClip hitsound;
    public AudioClip buttonSound;
    public AudioClip healSound;
    public AudioClip dushSound;
    public Text pointText;
    public float Dash = 5;

    private float timecountup = 0.0f;
    public float damagedcount = 2.0f;
    private bool isDamaged = false; //敵に当たったか

    AudioSource audioSource;

    int point = 6;
    GameObject timerText;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        timerText = GameObject.Find("Time");
    }
    void FixedUpdate()
    {
        Rigidbody2D rb = transform.GetComponent<Rigidbody2D>();
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var velocity = new Vector2(horizontal, vertical);
        rb.velocity = velocity.normalized * Dash;

        if (Input.GetButton("Dash"))
        {
            Dash = 8;
        }
        else
        {
            Dash = 3;
        }

        if (Input.GetButtonDown("Dash"))
        {
            audioSource.PlayOneShot(dushSound);
        }

        // ダメージを受けた状態
        if (isDamaged)
        {
            float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, level);
            damagedcount -= Time.deltaTime;
            if (damagedcount < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                isDamaged = false;
                damagedcount = 2.0f;
            }
        }

    }
    void Update()
    {
        //時間をカウントする
        timecountup += Time.deltaTime;
        pointText.text = point.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 障害物と衝突した場合
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (!isDamaged)
            {
                point--;
                audioSource.PlayOneShot(hitsound);
                isDamaged = true;
                if (point < 0)
                {
                    point = 0;
                    if (timecountup <= 30.0f)
                    {
                        SceneManager.LoadScene("ResultD");
                    }
                    if (timecountup >= 60.0f)
                    {
                        SceneManager.LoadScene("ResultC");
                    }
                    if (timecountup >= 90.0f)
                    {
                        SceneManager.LoadScene("ResultB");
                    }
                    if (timecountup >= 119.0f)
                    {
                        SceneManager.LoadScene("ResultA");
                    }
                }
            }
        }
        if (collision.gameObject.CompareTag("Heart"))
        {
            point++;
            audioSource.PlayOneShot(healSound);//回復音追加予定
        }
    }
}