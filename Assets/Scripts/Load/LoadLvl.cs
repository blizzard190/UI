using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLvl : MonoBehaviour
{
    [SerializeField] Image _Progressbar;
    private Functions _Functions;

    private void Start()
    {
        _Functions = GameObject.Find("GameManager").GetComponent<Functions>();
        StartCoroutine(LoadAsyncOperation(_Functions.lvl));
        Object.Destroy(_Functions.gameObject);
    }

    IEnumerator LoadAsyncOperation(int lvl)
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(lvl);

         while(gameLevel.progress < 1)
         {
             _Progressbar.fillAmount = gameLevel.progress;
             yield return new WaitForEndOfFrame();
         }
        //yield return new WaitForEndOfFrame();
    }
}
