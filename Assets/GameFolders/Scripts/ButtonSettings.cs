using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    private Animator _animator;
    private bool _isSetting;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SettingButton()
    {
        _animator.SetBool("isClick", !_isSetting);
        _isSetting = !_isSetting;
    }
    
    
}
