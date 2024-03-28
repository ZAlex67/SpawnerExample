using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _delay;
    [SerializeField] private int _enemyCount;

    private Vector3[] _position = new Vector3[] { new Vector3(-2, 0.52f, 0), new Vector3(2, 0.52f, 0) };

    private Vector3[] _direction = new Vector3[] { new Vector3(0, 0, 10), new Vector3(10, 0, 0), new Vector3(0, 10, 0) };

    private Enemy _newEnemy;

    private Vector3 _newDirection;

    private void Start()
    {
        StartCoroutine(Clone(_delay));
    }

    private void Update()
    {
        _newEnemy.Mover(_newDirection);
    }

    private IEnumerator Clone(float delay)
    {
        var wait = new WaitForSeconds(_delay);

        for (int i = 0; i < _enemyCount; i++)
        {
            _newEnemy = Instantiate(_enemy, _position[RandomPosition()], Quaternion.identity);
            _newDirection = _direction[RandomDirection()];

            yield return wait;
        }
    }

    private int RandomPosition()
    {
        return Random.Range(0, _position.Length);
    }

    private int RandomDirection()
    {
        return Random.Range(0, _direction.Length);
    }
}