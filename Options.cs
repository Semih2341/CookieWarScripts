using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Options : MonoBehaviour
{
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;
    public GameObject OptionsMenu;
    public GameObject DeathMenu;
    public GameObject PauseMenu;
    int OptionIndex;


    void Start()
    {
        resolutions= Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
                options.Add(option);

                if (resolutions[i].width == Screen.currentResolution.width&&
                resolutions[i].height==Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }
    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume",volume);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);  
    }
    public void Back()
    {
        OptionsMenu.SetActive(false);
        if (OptionIndex == 1)
        {
            DeathMenu.SetActive(true);
        }
        else
        {
            PauseMenu.SetActive(true);
        }
    }
    public void OptionsÖlünce()
    {
        DeathMenu.SetActive(false);
        OptionsMenu.SetActive(true);
        OptionIndex = 1;        
    }
}
