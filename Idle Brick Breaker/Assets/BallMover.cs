using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    [SerializeField] private float _baseMoveSpeed = 0.5f;

    private GameObject _thisGObj;
    private Transform _thisTf;
    private Rigidbody2D _thisRb;

    // Start is called before the first frame update
    void Start()
    {
        _thisGObj = this.gameObject;
        _thisTf = _thisGObj.transform;
        _thisRb = _thisGObj.GetComponent<Rigidbody2D>();

        _thisTf.Rotate(Vector3.forward, Random.Range(0f, 360f));
        MoveBall();
    }

    private void MoveBall()
    {
        _thisRb.velocity = _thisTf.up * _baseMoveSpeed;
    }
}
