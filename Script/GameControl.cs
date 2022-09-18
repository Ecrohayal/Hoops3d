using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class GameControl : MonoBehaviour
{
    public List<GameObject> cylinders;
    public GameObject panel,settingPanel;
    public ParticleSystem confetti;
    public Image image;
    public float imageCount;

    bool isPaused;

   
    private void Awake()
    {
       
        image.fillAmount = imageCount;

        confetti.Pause();

        isPaused = false;
        Time.timeScale = 1;
    }
    private void FixedUpdate()
    {
        if (cylinders.Count == 0)
        {
            StartCoroutine(finish());
        }

      

    }

    IEnumerator finish()
    {
        confetti.Play();

        yield return new WaitForSecondsRealtime(2f);

        panel.SetActive(true);
        image.fillAmount = 0f;

        yield return new WaitForSecondsRealtime(1f);

        
        image.fillAmount = imageCount;

        if(imageCount==1)
        {
            image.transform.DOScale(1.25f, 1f);
        }

        Destroy(confetti, 0.05f);
        
    }

    public void Pause()
    {
        isPaused = !isPaused;

        if(isPaused)
        {
            Time.timeScale = 0;

        }

        if (!isPaused)
        {
            Time.timeScale = 1;

        }
    }
    private void OnApplicationPause(bool pause)
    {
        isPaused = true;
        Time.timeScale = 0;
    }

    public void SettingPanel()
    {
        settingPanel.SetActive(true);
        Pause();
    }

    public void ExitSetting()
    {
        settingPanel.SetActive(false);
    }

    public void nextLevel(string nextLvl)
    {
        SceneManager.LoadScene(nextLvl);
    }

    public void TryAgain(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
