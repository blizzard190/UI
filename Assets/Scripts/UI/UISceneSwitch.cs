using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISceneSwitch : MonoBehaviour
{
    private List<ButtonManager> UIScenes;
    private int _LastActive = 0;
    private int _Active = 0;

    private void Start()
    {
        UIScenes = new List<ButtonManager>();
        int child = transform.childCount;
        for (int i = 0; i < child; i++)
        {
            UIScenes[i] = transform.GetChild(i).GetComponent<ButtonManager>();
            Debug.Log(UIScenes[i].gameObject);
        }
    }

    public void SwitchMenu(int Menu)
    {
        Debug.Log("ABS");
        _LastActive = _Active;
        UIScenes[_Active].CheckActive();
        _Active = Menu;
        UIScenes[_Active].CheckActive();
    }
}
