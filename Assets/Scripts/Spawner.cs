using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private SpawnerPoint[] _spawnerPoints;
    [SerializeField] private int _enemyCount;

    private void Start()
    {
        StartCoroutine(Spawn(_delay));
    }

    private IEnumerator Spawn(float delay)
    {
        var wait = new WaitForSeconds(_delay);

        for (int i = 0; i < _enemyCount; i++)
        {
            var _newPoint = _spawnerPoints[RandomIndex()];
            _newPoint.Spawn();

            yield return wait;
        }
    }

    private int RandomIndex()
    {
        return Random.Range(0, _spawnerPoints.Length);
    }
}