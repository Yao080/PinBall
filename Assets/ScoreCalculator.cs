using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    // Text�p�֐�
    private GameObject scoreText;
    // �X�R�A�v�Z�p�ϐ�
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        // �����X�R�A�������ĕ\��
        this.scoreText = GameObject.Find("ScoreText");
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    // �e�I�u�W�F�N�g�ɏՓ˂����ۂ̉��Z�X�R�A
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
