using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Btn : MonoBehaviour
{

    [SerializeField] private string _sceneName;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OpenScene);
    }

    private void OpenScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
