using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _delay;

    private Vector3[] _position = new Vector3[] { new Vector3(-2, 0.52f, 0), new Vector3(2, 0.52f, 0) };

    private void Start()
    {
        StartCoroutine(Clone(_delay));
    }

    private void Update()
    {
        Enemy._direction = new Vector3(0, 0, 0.04f);  
    }

    private IEnumerator Clone(float delay)
    {
        var wait = new WaitForSeconds(_delay);

        for (int i = 0; i >= 0; i++)
        {
            Instantiate(_enemy, _position[RandomPosition()], Quaternion.identity);

            yield return wait;
        }
    }

    private int RandomPosition()
    {
        return Random.Range(0, _position.Length);
    }
}