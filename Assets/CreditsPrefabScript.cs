using UnityEngine;
using UnityEngine.UI;

public class CreditsPrefabScript : MonoBehaviour
{
    [SerializeField] private VolumeSliderScript volumeSliderScript;
    [SerializeField] private Button closeButton;

    public void InitializeAll(AudioSource audioSource, CreditsScript creditsScript)
    {
        Debug.Log("initialize");
        volumeSliderScript.SetAudioSource(audioSource);
        closeButton.onClick.RemoveAllListeners();
        closeButton.onClick.AddListener(() => {
            audioSource.Play();
            creditsScript.CloseCredits();
        });
    }
}
