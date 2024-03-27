using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnObject;
    [SerializeField] private float _delay;

    private Vector3[] _position = new Vector3[] { new Vector3(-2, 0.52f, 0), new Vector3(2, 0.52f, 0) };

    private Vector3 _direction = new Vector3(0, 0, 0.04f);

    private Transform CubeClone;

    private void Start()
    {
        StartCoroutine(Clone(_delay));
    }

    private void Update()
    {
        CubeClone.transform.Translate(_direction);
    }

    private IEnumerator Clone(float delay)
    {
        var wait = new WaitForSeconds(_delay);

        for (int i = 0; i >= 0; i++)
        {
            CubeClone = Instantiate(_spawnObject, _position[RandomNumber()], Quaternion.identity);

            yield return wait;
        }
    }

    private int RandomNumber()
    {
        return Random.Range(0, _position.Length);
    }
}