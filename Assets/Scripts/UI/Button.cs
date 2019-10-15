using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    ButtonManager _ButtonManager;
    Animator _Animator;
    [SerializeField] int _ThisIndex;

    private void Start()
    {
        _Animator = this.GetComponent<Animator>();
        _ButtonManager = GetComponentInParent<ButtonManager>();
    }

    void Update()
    {
        if (_ButtonManager.index == _ThisIndex)
        {
            _Animator.SetBool("Selected", true);
            if (Input.GetAxis("Submit") == 1)
            {
                _Animator.SetBool("Pressed", true);
            }
            else if (_Animator.GetBool("Pressed"))
            {
                _Animator.SetBool("Pressed", false);
            }
        }
        else
        {
            _Animator.SetBool("Selected", false);
        }
    }
}
