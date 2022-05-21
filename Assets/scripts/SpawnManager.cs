using UnityEngine;


namespace Quest
{
    [CreateAssetMenu(fileName = "SpawnManager", menuName = "ScriptableObjects/SpawnManager", order = 1)]

    public class SpawnManager : ScriptableObject
    {
        [SerializeField] private string _prefabName;

        [SerializeField] private int _numberOfPrefabsToCrate;
        [SerializeField] private Vector3[] _spawnPoints;

        public string PrefabName => _prefabName;

        public int NumberOfPrefabsToCrate => _numberOfPrefabsToCrate;

        public Vector3[] SpawnPoints => _spawnPoints;
    }
}