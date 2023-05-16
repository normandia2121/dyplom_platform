using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

/*Tells a cut-scene to begin playing, and then load a scene when completed.*/

public enum EVideoState
{
    None = 0,
    Loading = 10,
    Playing = 20,
    Stopped = 30,
}

public class VideoController : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] string whichLevel;

    bool videoStarted;

    private void Awake()
    {
        videoPlayer.started += (x) => { videoStarted = true; };
    }

    private void Update()
    {
        if (videoStarted) if (!videoPlayer.isPlaying) StartGameOnVideoEnd();
    }

    void StartGameOnVideoEnd()
    {
        SceneManager.LoadScene(whichLevel);
        Destroy(gameObject);
    }
}
