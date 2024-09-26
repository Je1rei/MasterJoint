using UnityEngine;

[RequireComponent(typeof(Mover))] 
public class Spoon : MonoBehaviour
{
    [SerializeField] private SpringJoint _joint;
    [SerializeField] private Rigidbody _firstConnectionBody;
    [SerializeField] private Rigidbody _secondConnectionBody;
    [SerializeField] private float _multiprierForce = 1.3f;

    private float _force = 100f;

    private Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>(); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Switch(_secondConnectionBody, _multiprierForce);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Switch(_firstConnectionBody);
            _mover.ResetPosition();
        }
    }

    private void Switch(Rigidbody connectedBody, float multiplierForce = 1f)
    {
        _joint.spring = _force * multiplierForce;
        _joint.connectedBody = connectedBody;
    }
}