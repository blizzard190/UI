using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISceneSwitch : MonoBehaviour
{
    public List<ButtonManager> UIScenes;
    private int _LastActive = 0;
    private int _Active = 0;
    private ButtonManager _Manager;

    void Update()
    {
        _LastActive = _Active;
        _Manager = UIScenes[_Active].GetComponent<ButtonManager>();
        _Manager.CheckActive();
    }
}
