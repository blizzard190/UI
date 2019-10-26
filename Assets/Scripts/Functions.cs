using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public int lvl;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void LevelLoad(int level)
    {
        lvl = level;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
