using UnityEngine;

public class MetalItem : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private Transform _punsh;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Hummer _))
            PlayEffect();
    }

    private void PlayEffect()
    {
        _audio.Play();
        Instantiate(_particle, _punsh.position, Quaternion.identity);
    }
}
