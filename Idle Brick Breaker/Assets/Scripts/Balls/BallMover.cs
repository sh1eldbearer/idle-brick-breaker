using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    [SerializeField] private float _baseMoveSpeed = 0.5f;
    [SerializeField, Range(1f, 25f)] private float _rightAngleIgnoreRange = 1f;

    [Space, SerializeField] private LayerMask _wallLayer;

    private GameObject _thisGObj;
    private Transform _thisTf;
    private Rigidbody2D _thisRb;

    // Start is called before the first frame update
    private void Start()
    {
        _thisGObj = this.gameObject;
        _thisTf = _thisGObj.transform;
        _thisRb = _thisGObj.GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        // TODO: Delete this once Ball factory is properly implemented
        if (_thisGObj == null)
        {
            Start();
        }

        float initialAngle = Random.Range(0.0001f + _rightAngleIgnoreRange , 360.0001f - _rightAngleIgnoreRange);

        while ((90f - _rightAngleIgnoreRange < initialAngle && initialAngle < 90f + _rightAngleIgnoreRange) ||
               (180f - _rightAngleIgnoreRange < initialAngle && initialAngle < 180f + _rightAngleIgnoreRange) ||
               (270f - _rightAngleIgnoreRange < initialAngle && initialAngle < 270f + _rightAngleIgnoreRange))
        {
            initialAngle = Random.Range(0.0001f + _rightAngleIgnoreRange, 360.0001f - _rightAngleIgnoreRange);
        }

        Debug.Log("Initial angle is " + initialAngle);
        _thisTf.Rotate(Vector3.forward, Random.Range(0f, 360f));


        MoveBall();
    }

    private void MoveBall()
    {
        _thisRb.velocity = _thisTf.up * _baseMoveSpeed;
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
