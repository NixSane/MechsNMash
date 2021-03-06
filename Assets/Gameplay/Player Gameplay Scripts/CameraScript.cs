using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraScript : MonoBehaviour
{
    public CinemachineVirtualCamera thirdPersonVCam;

    Vector3 cameraDirection;

    public Vector3 GetDirection(Vector3 input)
    {
        cameraDirection = thirdPersonVCam.transform.forward * input.z + thirdPersonVCam.transform.right * input.x;
        cameraDirection.y = 0f;

        return cameraDirection.normalized;
    }
}
