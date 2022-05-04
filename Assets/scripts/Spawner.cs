using System;
using UnityEngine;

namespace Quest
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _entityToSpawn;
        [SerializeField] private SpawnManager _spawnManager;

        private int _instanceNumber = 1;

        private void Start()
        {
            SpawnEntities();
        }

        private void SpawnEntities()
        {
            var currentSpawnIndexPoint = 0;
            for (var i = 0; i < _spawnManager.NumberOfPrefabsToCrate; i++)
            {
                var currentEnttity = Instantiate(_entityToSpawn, _spawnManager.SpawnPoints[currentSpawnIndexPoint], Quaternion.identity);
                currentEnttity.name = _spawnManager.PrefabName + _instanceNumber;
                currentSpawnIndexPoint = (currentSpawnIndexPoint + 1) % _spawnManager.SpawnPoints.Length;

                _instanceNumber++;
            }
        }
    }
}