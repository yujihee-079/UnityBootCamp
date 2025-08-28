using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text bestText;
    private int score;
    private int best;
    // 싱글턴 객체 static 키워드 사용
    public static ScoreManager instance = null;

    
    // 싱글턴 객체에 값이 없으면 생성된 자기 자신을 할당
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            best = instance.best;
        }
    }

    public void SetScore(int value)
    {
        score += value; // 전달 받은 값만큼 점스를 증가시킨다.
        SetScoreText(score);

        if (score > best)
        {
            best = score;
            SetBestText(best);
            // 목표: 최고 점수를 저장하고 싶다. PlayerPrefs 함수를 사용해서 교재 내용대로 제작해봄.
            PlayerPrefs.SetInt("Best Score", best);

        }

    }

    private void SetScoreText(int score) => scoreText.text = $"Score :{score}";
    private void SetBestText(int best) => bestText.text =$"Score : {best}";

    public int GetScore() => score;
}
