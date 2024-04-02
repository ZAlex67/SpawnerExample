using System.Collections;
using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private Spawner[] _spawnerPoints;
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
            var _newPoint = _spawnerPoints[RandomPosition()];
            _newPoint.Clone();

            yield return wait;
        }
    }

    private int RandomPosition()
    {
        return Random.Range(0, _spawnerPoints.Length);
    }
}