using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private Rigidbody2D _rb;
    


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    protected void Movement()
    {
        _rb.velocity = _speed * GameData.DifficultMultiplier * Vector3.down;
    }
}
