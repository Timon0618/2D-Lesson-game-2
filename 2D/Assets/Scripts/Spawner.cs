using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int _ySpawnPoint = 15;
    [SerializeField] private float _spawnDelay = 2;
    [SerializeField] private GameObject _obstaclePref;


    private void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    private void Update()
    {
     /*   if (Input.GetKeyDown(KeyCode.C))
        {
            CreateObject();
        }*/
    }

    private IEnumerator SpawnTimer()
    {
        while (true)
        {
            CreateObject();

            yield return new WaitForSeconds(_spawnDelay);

            
        }
    }

    private void CreateObject()
    {
        float randomX = Random.Range(-18, 18);

        Instantiate(_obstaclePref, new Vector3(randomX, _ySpawnPoint), Quaternion.identity);
    }
}
