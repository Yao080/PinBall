using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    // Text用関数
    private GameObject scoreText;
    // スコア計算用変数
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        // 初期スコアを代入して表示
        this.scoreText = GameObject.Find("ScoreText");
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    // 各オブジェクトに衝突した際の加算スコア
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            score += 10;
        }
        if (yourTag == "LargeStarTag")
        {
            score += 20;
        }
        if (yourTag == "SmallCloudTag")
        {
            score += 20;
        }
        if (yourTag == "LargeCloudTag")
        {
            score += 30;
        }
        SetScore();
    }

    void SetScore()
    {
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }
}
