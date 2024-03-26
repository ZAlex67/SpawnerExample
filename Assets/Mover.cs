using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 _direction = new Vector3(0, 0, 0.04f);

    private void Update()
    {
        transform.Translate(_direction);
    }
}
