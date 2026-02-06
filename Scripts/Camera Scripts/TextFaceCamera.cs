using UnityEngine;

public class TextFaceCamera : MonoBehaviour
{
    private Camera _cameraToLookAt;

    private void Awake()
    {
        _cameraToLookAt = Camera.main;
    }

    void Update()
    {
        transform.LookAt(transform.position + _cameraToLookAt.transform.rotation * Vector3.forward,
            _cameraToLookAt.transform.rotation * Vector3.up);
    }
}
