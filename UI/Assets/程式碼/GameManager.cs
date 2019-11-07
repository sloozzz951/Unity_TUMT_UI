using UnityEngine;
using UnityEngine.Audio;

public class GameManager: MonoBehaviour {

    public AudioMixer 音樂管理器;

    public void SetVBGM(float value)
    {
        mixer.SetFloat("VBGM", value);
    }

    public void setVSFX(float value)
        mixer.setFloat("VSFX",value);
    }


