using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public int index;

    private Animator _Animator;
    private List<GameObject> _Buttons;
    private bool _Active;
    [SerializeField] bool _Keydown;
    [SerializeField] int _MaxIndex;

    private void Start()
    {
        _Animator = this.GetComponent<Animator>();

        /*int children = transform.childCount;
        for (int i = 0; i < children; i++)
        {
            _Buttons[i] = transform.GetChild(i).gameObject;
        }*/
    }

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

    public void CheckActive()
    {
        if (_Active)
        {
            _Active = false;
            _Animator.SetBool("In", false);
            _Animator.SetBool("Out", true);

        }
        else
        {
            _Active = true;
            _Animator.SetBool("Out", false);
            _Animator.SetBool("In", true);
        }
    }
    /*
    public void Activate()
    {
        foreach(GameObject child in _Buttons)
        {
            child.SetActive(true);
        }
    }

    public void DeActivate()
    {
        foreach(GameObject child in _Buttons)
        {
            child.SetActive(false);
        }
    }*/
}
