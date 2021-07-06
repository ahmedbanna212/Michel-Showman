using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class settings : MonoBehaviour
{
    Resolution[] resolutions;
    public AudioMixer audiomixer;
    public Dropdown resolutionDropDown;
    void Start() {
        resolutions = Screen.resolutions;
        resolutionDropDown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIdenx = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) {

                currentResolutionIdenx = i;
            }
        }
        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResolutionIdenx;
        resolutionDropDown.RefreshShownValue();
    }
   
    public void setVolume(float Volume) {
        audiomixer.SetFloat("volume", Volume);
       
    }
    public void fullscreen(bool full) {
        Screen.fullScreen = full;
    
    }
    public void SetResolution(int resolutionIndex) {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    
    }
}
