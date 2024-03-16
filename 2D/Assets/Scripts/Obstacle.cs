using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField] private float _speed = 1;

    protected void Movement()
    {
        transform.position += _speed * Time.deltaTime * Vector3.down;
    }
}
