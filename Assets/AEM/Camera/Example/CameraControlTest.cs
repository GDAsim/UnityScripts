using UnityEngine;

using AEM;

public class CameraControlTest : MonoBehaviour
{
    [SerializeField] AEMCameraControl cameraControl;

    void Start()
    {
        AEMCamera cam = cameraControl.GetCam(0);

        cameraControl.SetUpCam(0, 0, 0, Vector3.zero, Vector3.zero, CameraPreset.Chase);
        cameraControl.SetCameraActive(cam);
    }
}