using UnityEngine;
public class SecurityChange : MonoBehaviour
{
    public Camera[] cameras = new Camera[3];
    public bool changeAudioListener = true;
    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            EnableCamera(cameras[0], true);
            EnableCamera(cameras[1], false);
            EnableCamera(cameras[2], false);
        }
        if (Input.GetKeyDown("4"))
        {
            EnableCamera(cameras[0], false);
            EnableCamera(cameras[1], true);
            EnableCamera(cameras[2], false);
        }
        if (Input.GetKeyDown("5"))
        {
            EnableCamera(cameras[0], false);
            EnableCamera(cameras[1], false);
            EnableCamera(cameras[2], true);
        }
        if (Input.GetKeyDown("m"))
        {
            EnableCamera(cameras[0], false);
            EnableCamera(cameras[1], false);
            EnableCamera(cameras[2], false);
        }
    }
    private void EnableCamera(Camera cam, bool
    enabledStatus)
    {
        cam.enabled = enabledStatus;
        if (changeAudioListener)
            cam.GetComponent<AudioListener>().enabled =
            enabledStatus;
    }
}