using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _targetPosition;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition.transform.position, _speed * Time.deltaTime);
    }

    public void SetPosition(Target target)
    {
        _targetPosition = target;
    }
}