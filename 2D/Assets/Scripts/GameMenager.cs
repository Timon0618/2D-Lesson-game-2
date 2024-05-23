using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameMenager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private float _dmPerSecond;

    private void Start()
    {
        StartCoroutine(TickTimer());
        GameData.Score = 0;
    }

    private IEnumerator TickTimer()
    {
        while (true)
        {
            ScoreChanger();
            DifficultChanger();
            yield return new WaitForSeconds(1);
        }

    }

    private void DifficultChanger() => GameData.DifficultMultiplier += _dmPerSecond;


    private void ScoreChanger()
    {
        GameData.Score += GameData.DifficultMultiplier;
        _scoreText.text = ((int)GameData.Score).ToString();
    }

    public void SetPause()
    {
        Time.timeScale = 0;
    }

    public void ResetTimeScale()
    {
        Time.timeScale = 1;
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(1);
        ResetTimeScale();
        
    }

    public void MenuBtnClick()
    {
        SceneManager.LoadScene(0);
        ResetTimeScale();
    }
}
