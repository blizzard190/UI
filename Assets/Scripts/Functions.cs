using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Functions : MonoBehaviour
{
    LoadLvl _LoadLevel;

    private void Start()
    {
        _LoadLevel = this.GetComponent<LoadLvl>();
    }

    public void LevelLoad(int level)
    {
        // _LoadLevel.StartLoad(level);
        SceneManager.LoadScene(level);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
