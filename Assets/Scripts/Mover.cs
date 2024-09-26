using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Projectile _projectile;

    private Vector3 _startPoint;

    private void Awake()
    {
        _startPoint = _projectile.transform.position;
    }

    public void ResetPosition()
    {
        Rigidbody rigidbody = _projectile.GetComponent<Rigidbody>();

        if (rigidbody != null)
        {
            rigidbody.velocity = Vector3.zero;
        }

        _projectile.transform.position = _startPoint;
    }
}
