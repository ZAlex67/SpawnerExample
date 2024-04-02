using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Player _playerPosition;

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition.transform.position, _speed * Time.deltaTime);
    }

    public void ChangePosition(Player player)
    {
        _playerPosition = player;
    }
}