using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ControlScript : MonoBehaviour
{
    [SerializeField]
    private GameObject openingAnimationPanel;
    [SerializeField]
    private VideoClip startMenuClip;
    [SerializeField]
    private VideoPlayer myVideoPlayer;
    [SerializeField]
    private RawImage myRawImage;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("InvokedFunction",2f);

        myVideoPlayer.loopPointReached += StartNewClip;
        myVideoPlayer.Play();
        myRawImage.enabled = true;
    }

    //void InvokedFunction()
    //{
    //    openingAnimationPanel.SetActive(true);
    //}

    void StartNewClip(VideoPlayer myVidPlayer)
    {
        myVideoPlayer.clip = startMenuClip;
        myVideoPlayer.isLooping = true;
    }

   
}
