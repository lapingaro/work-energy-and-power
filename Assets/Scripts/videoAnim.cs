using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class videoAnim : MonoBehaviour
{
    public VideoPlayer splashVideoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        splashVideoPlayer = this.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        //check of there is a video loaded on video player
        if (splashVideoPlayer.length > 1)
        {
            if (splashVideoPlayer.isPlaying == false)
            {
                //SceneManager.LoadScene(1);
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
