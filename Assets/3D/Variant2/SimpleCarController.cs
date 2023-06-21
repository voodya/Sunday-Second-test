using UnityEngine;
using System.Collections;
using System.Collections.Generic;
    
public class SimpleCarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque = 6500; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have

    [SerializeField] private List<Speed> _speeds;
    [SerializeField] private float _defaultRotate = 1000f;
    [SerializeField] private int _targetSpeed;
    [SerializeField] private Speed _targetSpeedEl;



    private void Start()
    {
        _targetSpeed = 0;
    }



    public void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            _targetSpeed++;
            if (_targetSpeed >= _speeds.Count) _targetSpeed = _speeds.Count - 1;
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            _targetSpeed--;
            if (_targetSpeed <= 0) _targetSpeed = 0;
        }
        
        
        float motor = _defaultRotate * Input.GetAxis("Vertical") * -1;


        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor * _speeds[_targetSpeed]._coef;
                axleInfo.rightWheel.motorTorque = motor * _speeds[_targetSpeed]._coef;
            }
        }
    }
}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
}


[System.Serializable]
public class Speed
{
    public string _speed;

    [Range(1, 6000)]
    public int _rotateMin;

    [Range(1, 6000)]
    public int _rotateMax;

    public float _coef;

    

}

