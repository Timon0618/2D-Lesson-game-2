using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : Obstacle
{
    [SerializeField] private float _minSize = 0.8f;
    [SerializeField] private float _maxSize = 1.2f;
    private SpriteRenderer _sr;




    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        AppearanceRandomizer();
    }


    private void FixedUpdate()
    {
        Movement();
    }




    private void AppearanceRandomizer()
    {
        float randomSize = Random.Range(_minSize, _maxSize);

        transform.localScale = Vector3.one * randomSize;

        //transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
        transform.eulerAngles = new Vector3(0, 0, Random.Range(-180, 180));

        _sr.flipX = Random.Range(0, 2) == 0;
        _sr.flipY = Random.Range(0, 2) == 0;
    }
}
