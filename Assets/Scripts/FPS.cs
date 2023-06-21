using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPS : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        _text.text = $"FPS: {(int)(1.0f / Time.deltaTime)} \n Frame Time: {Time.deltaTime * 1000}";
    }
}
