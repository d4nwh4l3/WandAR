using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public Toggle soundToggle;
    public Toggle musicToggle;

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    private void Start()
    {
        soundToggle.onValueChanged.AddListener(OnSoundToggle);
        musicToggle.onValueChanged.AddListener(OnMusicToggle);
    }

    private void OnSoundToggle(bool isOn)
    {
        Debug.Log("Sound toggled: " + isOn);
        // You could mute/unmute SFX AudioMixer group here
    }

    private void OnMusicToggle(bool isOn)
    {
        Debug.Log("Music toggled: " + isOn);
        // You could mute/unmute music AudioMixer group here
    }
}
