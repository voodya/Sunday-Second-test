using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureConfig : MonoBehaviour
{
    [SerializeField] private RenderTexture _target;

    private void Awake()
    {
        _target.height = Screen.height/4;
        _target.width = Screen.width/4;
    }
}
