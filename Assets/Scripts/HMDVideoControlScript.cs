using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class HMDVideoControlScript : MonoBehaviour
{
    public VideoPlayer HMDVideoPlayer;

    void Start()
    {
        HMDVideoPlayer = this.GetComponent<VideoPlayer>();
    }


    void Update()
    {
        PlayHMDVideo();
    }

    private void PlayHMDVideo()
    {
        //check of there is a video loaded on video player
        if (HMDVideoPlayer.length > 3)
        {
            if (HMDVideoPlayer.isPlaying == false)
            {
                //delay loading the next scene
                SceneManager.LoadScene("main_scene");
            }
        }
    }
}
