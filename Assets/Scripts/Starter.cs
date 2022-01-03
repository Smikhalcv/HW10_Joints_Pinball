using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    private SpringJoint _starter;
    private Vector3 _anchor;
    [SerializeField] private float _maxDistanceStrikeY;
    private float _startValueY;

    void Start()
    {
        _starter = GetComponent<SpringJoint>();
        _startValueY = _starter.anchor.y;
        _anchor = _starter.anchor;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _anchor.y = _maxDistanceStrikeY;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _anchor.y = _startValueY;            
        }
        _starter.anchor = _anchor;
    }
}
