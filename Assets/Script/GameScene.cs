using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GameScene : MonoBehaviour
{
    GameObject musicPlayer;
    [SerializeField] AudioClip music;

    // Start is called before the first frame update
    void Start()
    {
        ChnageGameMusic();
    }

    private void ChnageGameMusic()
    {
        MusicPlayer.Instance.ChangeMusic(music);
        MusicPlayer.Instance.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
