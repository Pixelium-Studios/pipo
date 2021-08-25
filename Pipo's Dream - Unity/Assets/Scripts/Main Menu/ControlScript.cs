using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ControlScript : MonoBehaviour
{
    [SerializeField]
    private GameObject video_panel_loading;
    [SerializeField]
    private GameObject video_panel_start_menu;


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
        video_panel_loading.SetActive(false);
        video_panel_start_menu.SetActive(true);
        //myVideoPlayer.loopPointReached -= StartNewClip;
    }

   
}
