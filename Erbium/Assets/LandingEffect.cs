using UnityEngine;

public class LandingEffect : MonoBehaviour
{
    public ParticleSystem landingDust;

    private bool wasGrounded;

    void Update()
    {
        bool grounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        if (!wasGrounded && grounded)
        {
            landingDust.Play();
        }

        wasGrounded = grounded;
    }
}