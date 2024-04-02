using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Player _player;

    private Enemy _newEnemy;

    //������ ���� ����� (� ������� �������� ���� ����)
    private void Update()
    {
        if (_newEnemy != null)
            _newEnemy.SetPlayer(_player);
    }

    public void Spawn()
    {
        _newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
    }
}