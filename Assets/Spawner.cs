using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private float _timeSpawn;

    private Vector3[] _position = new Vector3[] { new Vector3(-2, 0.52f, 0), new Vector3(2, 0.52f, 0)};

    private float _timer;

    private void Start()
    {
        _timer = _timeSpawn;
    }

    private void Update()
    {
        SpawnCube();
    }

    private void SpawnCube()
    {
        int random = Random.Range(0, _position.Length);

        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            _timer = _timeSpawn;
            Instantiate(_spawnObject, _position[random] , Quaternion.identity, transform).AddComponent<Mover>();
        }
    }
}