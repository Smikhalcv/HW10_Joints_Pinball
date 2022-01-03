using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBeater : MonoBehaviour
{
    private HingeJoint _hingeJointBeater;
    private AudioSource _soundBeater;

    void Start()
    {
        _hingeJointBeater = GetComponent<HingeJoint>();
        _soundBeater = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _hingeJointBeater.useMotor = true;
            _soundBeater.Play();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _hingeJointBeater.useMotor = false;
        }

    }
}
