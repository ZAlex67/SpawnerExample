using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private MoverEnemy _enemy;
    [SerializeField] private Target _target;

    private MoverEnemy _newEnemy;

    private void Update()
    {
        SetTarget();
    }

    private void SetTarget()
    {
        if (_newEnemy != null)
            _newEnemy.SetPosition(_target);
    }

    public void Spawn()
    {
        _newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
    }
}