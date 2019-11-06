using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationFuntcions : MonoBehaviour
{
    Functions _GameManager;
    UISceneSwitch _UISceneManager;

    void Start()
    {
        _GameManager = GameObject.Find("GameManager").GetComponent<Functions>();
        _UISceneManager = GameObject.Find("UISceneManager").GetComponent<UISceneSwitch>();
    }

    public void Quit()
    {
        _GameManager.Quit();
    }

    public void SwitchMenu(int Menu)
    {
        _UISceneManager.SwitchMenu(Menu);
    }

    public void Lvl(int lvl)
    {
        _GameManager.LevelLoad(lvl);
    }
}
