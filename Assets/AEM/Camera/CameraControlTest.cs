using AEM;
using UnityEngine;

public class CameraControlTest : MonoBehaviour
{
    public AEMCameraControl t;

    public void Awake()
    {
        if (t == null)
        {
            t = GetComponent<AEMCameraControl>();
        }
    }   
    void Start()
    {
        if (t == null)
        {
            enabled = false;
            Debug.Log(this.gameObject + " Could Not Find CameraControl script");
        }
        else
        {
            AEMCamera a = t.GetCam(Random.Range(0, t.Cameralist.Count - 1));
            t.SetUpCam(0,0,0, Vector3.zero, Vector3.zero,CameraPreset.Chase);
            a.Cam.enabled = true;
        }
    }
}