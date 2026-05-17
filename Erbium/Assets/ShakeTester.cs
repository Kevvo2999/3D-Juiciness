using UnityEngine;

public class ShakeTester : MonoBehaviour
{
    public CameraShake cameraShake;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(cameraShake.Shake(0.5f, 0.5f));
        }
    }
}