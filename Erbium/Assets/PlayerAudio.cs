using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip jumpSound;
    public AudioClip attackSound;
    public AudioClip runSound;

    private bool isRunningSoundPlaying = false;

    void Update()
    {
        // SALTO
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(jumpSound);
        }

        // ATAQUE
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(attackSound);
        }

        // CORRER
        if (Input.GetKey(KeyCode.W))
        {
            if (!isRunningSoundPlaying)
            {
                audioSource.clip = runSound;
                audioSource.loop = true;
                audioSource.Play();

                isRunningSoundPlaying = true;
            }
        }
        else
        {
            if (isRunningSoundPlaying)
            {
                audioSource.Stop();

                isRunningSoundPlaying = false;
            }
        }
    }
}