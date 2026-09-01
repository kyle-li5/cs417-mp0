using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

public class CreditsScript : MonoBehaviour
{
    [SerializeField] GameObject credits;
    [SerializeField] AudioSource audioSource;
    [SerializeField] CreditsScript creditsScript;

    private GameObject creditsInstance;

    public void OpenCredits()
    {
        creditsInstance = Instantiate(credits);
        CreditsPrefabScript script = creditsInstance.gameObject.GetComponent<CreditsPrefabScript>();
        script.InitializeAll(audioSource, creditsScript);
    }

    public void CloseCredits()
    {
        Destroy(creditsInstance);
    }
}
