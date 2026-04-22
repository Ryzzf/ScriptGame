using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TMP_Text Namapanel;

    public Slider volumeSlider;
    public AudioSource audioSource;

    void Start()
    {
        if (volumeSlider != null && audioSource != null)
        {
            volumeSlider.value = audioSource.volume;
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }
    }

    public void setNamaPanel(string nama)
    {
        Namapanel.text = nama;
    }

    public void LoadScene(string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
    }

    public void KeluarAplikasi()
    {
        Application.Quit();

        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void SetVolume(float value)
    {
        audioSource.volume = value;
    }
}