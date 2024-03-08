using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 moveDirection;

    private void Update()
    {
        HandleMove();
    }


    private void HandleMove()
    {

    }

    private void RotatePlayerAccordingToInput(Vector3 cameraRelativeMovement)
    {
        Vector3 pointToLookAt;
        pointToLookAt.x = cameraRelativeMovement.x;
        pointToLookAt.y = 0;
        pointToLookAt.z = cameraRelativeMovement.z;

        Quaternion currentRotation = transform.rotation;

        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotaion = Quaternion.LookRotation(pointToLookAt);
        }
    }

    private Vector3 ConvertMoveDirectionToCameraSpace()
    {
        return Vector3.zero;
    }
}
