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
        for (int i = 0; i < transform.childCount; i++)
        {
            UIScenes.Add(this.gameObject.transform.GetChild(i).GetComponent<ButtonManager>());
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
