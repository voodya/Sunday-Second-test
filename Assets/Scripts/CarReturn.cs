using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarReturn : MonoBehaviour
{
    [SerializeField] private Button _returnBtn;
    [SerializeField] private Transform _returnTransform;
    private Vector3 _position;
    private Quaternion _rotation;
    
    private void Start()
    {
        _position = _returnTransform.position;
        _rotation = _returnTransform.rotation;
        _returnBtn.onClick.AddListener(OnReturn);
    }

    private void OnReturn()
    {
        _returnTransform.rotation = _rotation;
        _returnTransform.position = _position;
    }
}
