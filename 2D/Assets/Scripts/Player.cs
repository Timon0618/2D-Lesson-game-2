using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private TMP_Text _scoreText;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }


    private void FixedUpdate()
    {
        PhysicalMove();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Obstacle>())
        {
            _losePanel.SetActive(true);
            _scoreText.text = GameData.Score.ToString();
            Time.timeScale = 0;
            Destroy(gameObject);
        }

    }

    private void PhysicalMove()
    {
        float xDir = Input.GetAxis("Horizontal");
        float yDir = Input.GetAxis("Vertical");

        _rb.velocity = _speed * new Vector3(xDir, yDir);
    }
}
