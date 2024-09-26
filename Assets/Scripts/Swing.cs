using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private HingeJoint _joint;
    [SerializeField] private float _motorSpeed = 100f;
    [SerializeField] private float _motorForce = 1000f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Move();
        }
    }

    private void Move()
    {
        JointMotor motor = _joint.motor;
        motor.force = _motorForce;
        motor.targetVelocity = _motorSpeed;
        _joint.motor = motor;

        _joint.useMotor = true;
    }
}
