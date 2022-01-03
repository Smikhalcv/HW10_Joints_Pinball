using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosBall;
    private Quaternion _startRotateBall = Quaternion.Euler(0, 0, 0);
    [SerializeField] GameObject _prefabBall;


    private void Start()
    {
        ReturnBall();
    }

    private void ReturnBall()
    {
        Instantiate(_prefabBall, _startPosBall, _startRotateBall);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            ReturnBall();
        }
    }
}
