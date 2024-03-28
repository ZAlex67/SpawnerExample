using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Vector3 _direction;

    private void Start()
    {
        
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.Translate(_direction);
    }
}