using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinders : MonoBehaviour
{
    [SerializeField] private float _power;
    private Vector3 _positionCylinder;
    private Vector3 _direction;
    private Light _pointLight;
    private AudioSource _soundBell;

    void Start()
    {
        _positionCylinder = transform.position;
        _pointLight = GetComponentInChildren<Light>();
        _soundBell = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _direction = collision.transform.position - _positionCylinder;
        collision.rigidbody.AddForce(_direction.normalized * _power, ForceMode.Impulse);
        _pointLight.intensity = 10;
        _soundBell.Play();
    }

    private void OnCollisionExit(Collision collision)
    {
        _pointLight.intensity = 1;
    }
}
