using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSliderScript : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] AudioSource audioSource;
    [SerializeField] float maxDb = 5f;
    [SerializeField] private float cooldown = .4f;

    private float nextSound;

    void Start()
    {
        slider.minValue = 0.0001f;
        slider.maxValue = Mathf.Pow(10f, maxDb / 20f);

        float volume;
        audioMixer.GetFloat("masterVol", out volume);
        slider.value = Mathf.Pow(10f, volume / 20f);
    }
    
    public void SetVolLvl(float lvl)
    {
        audioMixer.SetFloat("masterVol", 20f * Mathf.Log10(Mathf.Clamp(lvl, slider.minValue, slider.maxValue)));
        Debug.Log(lvl);
        if (Time.time >= nextSound)
        {
            audioSource.Play();
            nextSound = Time.time + cooldown;
        }
    }

    public void SetAudioSource(AudioSource source)
    {
        audioSource = source;
    }
}
