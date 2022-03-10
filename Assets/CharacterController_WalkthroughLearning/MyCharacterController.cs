using KinematicCharacterController;
using UnityEngine;

public class MyCharacterController : MonoBehaviour, ICharacterController
{
    private KinematicCharacterMotor motor;

    [Header("Stable Movement")]
    [SerializeField] private float MaxStableMoveSpeed = 10f;
    [SerializeField] private float SttableMovementSharpness = 15;
    [SerializeField] private float OrientationSharpness = 10;

    [Header("Air Movement")]
    [SerializeField] private float MaxAirMoveSpeed = 10f;
    [SerializeField] private float AirAccelerationSpeed = 5f;
    [SerializeField] private float Drag = 0.1f;

    [Header("Misc")]
    [SerializeField] private bool RotationObstruction;
    [SerializeField] private Vector3 Gravity = new Vector3(0, -30f, 0);
    [SerializeField] private Transform MeshRoot;

    private void Start()
    {
        motor = GetComponent<KinematicCharacterMotor>();
        motor.CharacterController = this;
    }

    public void UpdateRotation(ref Quaternion currentRotation, float deltaTime)
    {
        throw new System.NotImplementedException();
    }



    private Vector3 _moveInputVector;
    private Vector3 _lookInputVector;

    public void UpdateVelocity(ref Vector3 currentVelocity, float deltaTime)
    {
        Vector3 targetMovementVelocity = Vector3.zero;
        if (motor.GroundingStatus.IsStableOnGround)
        {
            currentVelocity = motor.GetDirectionTangentToSurface
                (currentVelocity, motor.GroundingStatus.GroundNormal) * currentVelocity.magnitude;

            Vector3 inputRight = Vector3.Cross(_moveInputVector, motor.CharacterUp);
            Vector3 reorientedInput = Vector3.Cross(motor.GroundingStatus.GroundNormal, inputRight).normalized *
                                      _moveInputVector.magnitude;
            targetMovementVelocity = reorientedInput * MaxStableMoveSpeed;

            currentVelocity = Vector3.Lerp(currentVelocity, targetMovementVelocity,
                1 - Mathf.Exp(MaxStableMoveSpeed * deltaTime));
        }
        else
        {
            // Add move input
            if (_moveInputVector.sqrMagnitude > 0f)
            {
                targetMovementVelocity = _moveInputVector * MaxAirMoveSpeed;

                // Prevent climbing on un-stable slopes with air movement
                if (motor.GroundingStatus.FoundAnyGround)
                {
                    Vector3 perpenticularObstructionNormal = Vector3.Cross(Vector3.Cross(motor.CharacterUp, motor.GroundingStatus.GroundNormal), motor.CharacterUp).normalized;
                    targetMovementVelocity = Vector3.ProjectOnPlane(targetMovementVelocity, perpenticularObstructionNormal);
                }

                Vector3 velocityDiff = Vector3.ProjectOnPlane(targetMovementVelocity - currentVelocity, Gravity);
                currentVelocity += velocityDiff * AirAccelerationSpeed * deltaTime;
            }

            // Gravity
            currentVelocity += Gravity * deltaTime;

            // Drag
            currentVelocity *= (1f / (1f + (Drag * deltaTime)));
        }
    }

    public void BeforeCharacterUpdate(float deltaTime)
    {
        throw new System.NotImplementedException();
    }

    public void PostGroundingUpdate(float deltaTime)
    {
        throw new System.NotImplementedException();
    }

    public void AfterCharacterUpdate(float deltaTime)
    {
        throw new System.NotImplementedException();
    }

    public bool IsColliderValidForCollisions(Collider coll)
    {
        throw new System.NotImplementedException();
    }

    public void OnGroundHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint,
        ref HitStabilityReport hitStabilityReport)
    {
        throw new System.NotImplementedException();
    }

    public void OnMovementHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint,
        ref HitStabilityReport hitStabilityReport)
    {
        throw new System.NotImplementedException();
    }

    public void ProcessHitStabilityReport(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint,
        Vector3 atCharacterPosition,
        Quaternion atCharacterRotation, ref HitStabilityReport hitStabilityReport)
    {
        throw new System.NotImplementedException();
    }

    public void OnDiscreteCollisionDetected(Collider hitCollider)
    {
        throw new System.NotImplementedException();
    }
}