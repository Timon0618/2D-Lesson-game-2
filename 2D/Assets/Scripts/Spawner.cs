using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int _ySpawnPoint = 15;
    [SerializeField] private GameObject _obstaclePref;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CreateObject();
        }
    }

    private void CreateObject()
    {
        float randomX = Random.Range(-18f, 18f);

        Instantiate(_obstaclePref, new Vector3(randomX, _ySpawnPoint), Quaternion.identity);
    }
}
