using System.Linq;
using System.Collections.Generic;

using UnityEngine;

using AEM;

public class AEMCameraControl : MonoBehaviour
{
    public AEMCamera ActiveCamera { get; private set; }
    public List<AEMCamera> Cameralist;

    [SerializeField] protected List<GameObject> Maintargets;
    [SerializeField] protected List<GameObject> Looktargets;

    public void AddMainTarget(GameObject inmain)
    {
        Maintargets.Add(inmain);
    }
    public void RemoveMainTarget(GameObject inmain)
    {
        foreach (GameObject go in Maintargets)
        {
            if (inmain == go)
            {
                Maintargets.Remove(inmain);
                return;
            }
        }
    }
    public void AddLookTarget(GameObject inlook)
    {
        Looktargets.Add(inlook);
    }
    public void RemoveLookTarget(GameObject inlook)
    {
        foreach (GameObject go in Looktargets)
        {
            if (inlook == go)
            {
                Maintargets.Remove(inlook);
                return;
            }
        }
    }

    void Awake()
    {
        if (Cameralist.Count == 0)
        {
            GetAllCamInGame();
        }
    }

    void GetAllCamInGame()
    {
        Cameralist = FindObjectsByType<AEMCamera>(FindObjectsInactive.Include, FindObjectsSortMode.None).ToList();
    }

    // Public
    public AEMCamera GetCam(int i)
    {
        if (i < Cameralist.Count)
        {
            return Cameralist[i];
        }
        throw new UnityException("GetCam Index Not Correct");
    }

    public void SetCameraActive(AEMCamera incam)
    {
        foreach (AEMCamera cam in Cameralist)
        {
            bool active = cam == incam;
            cam.unityCamera.enabled = active;

            if (active)
            {
                ActiveCamera = cam;
            }
        }
    }

    public void SetUpCam(AEMCamera cam, GameObject mainTarget, GameObject lookAtTarget, Vector3 inPosOffset, Vector3 inRotOffset, CameraPreset preset = CameraPreset.FixedLook)
    {
        cam.MainTarget = mainTarget;
        cam.LookAtTarget = lookAtTarget;
        cam.CameraType = preset;
        cam.CamPosOffset = inPosOffset;
        cam.CamRotOffset = inRotOffset;
    }
    public void SetUpCam(int i, int mainTargetindex, int lookAtTargetindex, Vector3 inPosOffset, Vector3 inRotOffset, CameraPreset preset = CameraPreset.FixedLook)
    {
        SetCamMainTarget(i, mainTargetindex);
        SetCamLookat(i, lookAtTargetindex);
        SetCamPreset(i, preset);
        SetCamPositionOffset(i, inPosOffset);
        SetCamRotationOffset(i, inRotOffset);
    }
    public void SetCamMainTarget(int i, int intarget)
    {
        if (i >= Cameralist.Count)
        {
            print("Camera index" + i + " does not exist");
            return;
        }
        if (intarget >= Maintargets.Count)
        {
            print("Maintargets [index " + intarget + "] does not exist");
            return;
        }
        Cameralist[i].MainTarget = Maintargets[intarget];
    }
    public void SetCamLookat(int i, int lookAtTarget)
    {
        if (i >= Cameralist.Count)
        {
            print("Camera index" + i + " does not exist");
            return;
        }
        if (lookAtTarget >= Looktargets.Count)
        {
            print("LookAtTarget [index " + lookAtTarget + "] does not exist");
            return;
        }
        Cameralist[i].LookAtTarget = Looktargets[lookAtTarget];
    }
    public void SetCamPreset(int i, CameraPreset preset)
    {
        Cameralist[i].CameraType = preset;
    }
    public void SetCamPositionOffset(int i, Vector3 inPosOffset)
    {
        Cameralist[i].CamPosOffset = inPosOffset;
    }
    public void SetCamRotationOffset(int i, Vector3 inRotOffset)
    {
        Cameralist[i].CamRotOffset = inRotOffset;
    }
}