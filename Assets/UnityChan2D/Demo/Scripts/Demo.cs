using UnityEngine;

namespace UnityChan2D.Demo
{
    [RequireComponent(typeof(UnityChan2DController), typeof(AudioSource))]
    public class Demo : MonoBehaviour
    {
        [SerializeField]
        private AudioClip damageVoice;

        [SerializeField]
        private AudioClip[] jumpVoices;

        [SerializeField]
        private AudioClip clearVoice;

        [SerializeField]
        private AudioClip timeOverVoice;

        private AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        private void OnDamage()
        {
            PlayVoice(damageVoice);
        }

        private void Jump()
        {
            int i = Random.Range(0, jumpVoices.Length);
            PlayVoice(jumpVoices[i]);
        }

        private void Clear()
        {
            PlayVoice(clearVoice);
        }

        private void TimeOver()
        {
            PlayVoice(timeOverVoice);
        }

        private void PlayVoice(AudioClip voice)
        {
            audioSource.Stop();
            audioSource.PlayOneShot(voice);
        }
    }
}