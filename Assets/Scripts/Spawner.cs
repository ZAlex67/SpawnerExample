using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Player _player;

    private Enemy _newEnemy;

    private void Update()
    {
        if (_newEnemy != null)
            _newEnemy.ChangePosition(_player);
    }

    public void Clone()
    {
        _newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
    }
}