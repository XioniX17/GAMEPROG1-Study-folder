using UnityEngine;

public class ExplosionParticle : MonoBehaviour
{
    private ParticleSystem explosionParticle;

    private void Start()
    {
        explosionParticle = GetComponent<ParticleSystem>();
    }

    public void Explode()
    {
        explosionParticle.Play();
    }
}
