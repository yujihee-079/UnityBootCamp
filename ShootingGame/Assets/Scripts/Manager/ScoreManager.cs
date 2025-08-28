using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text bestText;
    private int score;
    private int best;
    // �̱��� ��ü static Ű���� ���
    public static ScoreManager instance = null;

    
    // �̱��� ��ü�� ���� ������ ������ �ڱ� �ڽ��� �Ҵ�
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
        score += value; // ���� ���� ����ŭ ������ ������Ų��.
        SetScoreText(score);

        if (score > best)
        {
            best = score;
            SetBestText(best);
            // ��ǥ: �ְ� ������ �����ϰ� �ʹ�. PlayerPrefs �Լ��� ����ؼ� ���� ������ �����غ�.
            PlayerPrefs.SetInt("Best Score", best);

        }

    }

    private void SetScoreText(int score) => scoreText.text = $"Score :{score}";
    private void SetBestText(int best) => bestText.text =$"Score : {best}";

    public int GetScore() => score;
}
