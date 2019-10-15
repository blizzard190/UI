using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLvl : MonoBehaviour
{
    [SerializeField] Image _Progressbar;

    public void StartLoad(int lvl)
    {
        StartCoroutine(LoadAsyncOperation(lvl));
    }

    IEnumerator LoadAsyncOperation(int lvl)
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(lvl);

        while(gameLevel.progress < 1)
        {
            _Progressbar.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
    }
}
