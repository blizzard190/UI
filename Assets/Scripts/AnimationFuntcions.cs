using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationFuntcions : MonoBehaviour
{
    Functions _GameManager;
    void Start()
    {
        _GameManager = GameObject.Find("GameManager").GetComponent<Functions>();
    }

    public void Quit()
    {
        _GameManager.Quit();
    }

    public void Lvl(int lvl)
    {
        _GameManager.LevelLoad(lvl);
    }
}
