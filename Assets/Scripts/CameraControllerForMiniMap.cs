using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerForMiniMap : MonoBehaviour
{
    [SerializeField] private Transform _car;

    private Transform _camera;

    private void Start()
    {
        _camera = transform;
    }

    private void Update()
    {
        _camera.position = new Vector3(_car.position.x, 200f, _car.position.z);
    }
}
