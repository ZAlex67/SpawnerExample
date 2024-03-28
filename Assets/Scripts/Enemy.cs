using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Mover(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime);
    }
}