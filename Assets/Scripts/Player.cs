using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction * Time.deltaTime);
    }
}