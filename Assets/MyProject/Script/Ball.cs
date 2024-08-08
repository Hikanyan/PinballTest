using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        float randomX = UnityEngine.Random.Range(-1f, 1f);
        _rigidbody.velocity = new Vector3(0, 0, randomX) * _speed;
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        // Paddleに当たった時に跳ね返る
        if (other.gameObject.CompareTag("Paddle"))
        {
            Debug.Log("Paddleに当たった");
        }
    }
}