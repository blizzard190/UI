using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISceneSwitch : MonoBehaviour
{
    public List<ButtonManager> UIScenes;
    private int _LastActive = 0;
    private int _Active = 0;

    private void Start()
    {
        int child = transform.childCount;
        for (int i = 0; i < child; i++)
        {
            UIScenes[i] = transform.GetChild(i).GetComponent<ButtonManager>();
        }
    }

    public void SwitchMenu(int Menu)
    {
        _LastActive = _Active;
        UIScenes[_Active].CheckActive();
        _Active = Menu;
        UIScenes[_Active].CheckActive();
    }
}
