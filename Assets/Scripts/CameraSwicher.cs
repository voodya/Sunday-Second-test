using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwicher : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private Camera _topCamera;

    [SerializeField] private Button _switchBtn;

    private void Start()
    {
        _switchBtn.onClick.AddListener(SwichTextures);
    }

    private void SwichTextures()
    {
        RenderTexture Temp = _mainCamera.targetTexture;
        _mainCamera.targetTexture = _topCamera.targetTexture;
        _topCamera.targetTexture = Temp;
    }
}
