using UnityEngine;

using UnityEngine;

public class DustController : MonoBehaviour
{
    public ParticleSystem dust;
    public Rigidbody rb;

    void Update()
    {
        if (rb.linearVelocity.magnitude > 2f)
        {
            if (!dust.isPlaying)
            {
                dust.Play();
            }
        }
        else
        {
            if (dust.isPlaying)
            {
                dust.Stop();
            }
        }
    }
}
