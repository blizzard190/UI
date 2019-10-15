using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public int index;

    [SerializeField] bool _Keydown;
    [SerializeField] int _MaxIndex;

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            if (!_Keydown)
            {
                _Keydown = true;
                if (Input.GetAxis("Vertical") < 0)
                {
                    if (index < _MaxIndex)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                }
                else if (Input.GetAxis("Vertical") > 0)
                {
                    if (index > 0)
                    {
                        index--;
                    }
                    else
                    {
                        index = _MaxIndex;
                    }
                }
            }
        }
        else
        {

            _Keydown = false;
        }
    }
}
