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
    private float initialPlayDelay = 1.5f;
    [SerializeField]
    private RawImage myRawImage;
    [SerializeField]
    private VideoPlayer loading_video_player;
    [SerializeField]
    private VideoPlayer start_menu_video_player;
    [SerializeField]
    private Button startButton;

    //private long startMenuLastFrame = 

    private RawImage video_panel_loading_rawImage;
    
    // Start is called before the first frame update
    void Start()
    {
        loading_video_player.loopPointReached += StartNewClip;
        video_panel_loading_rawImage = video_panel_loading.GetComponent<RawImage>();
        loading_video_player.Play();                
        Invoke("InvokedFunction", initialPlayDelay);

        start_menu_video_player.sendFrameReadyEvents = true;
        start_menu_video_player.frameReady += CheckForLastFrame;
    }

    void InvokedFunction()
    {
        video_panel_loading_rawImage.enabled = true;        
    }

    void StartNewClip(VideoPlayer myVidPlayer)
    {
        // myVidPlayer je od prethodnog panela, NIJE ISTI VideoPlayer kao na 2nd panelu

        video_panel_loading.SetActive(false);
        video_panel_start_menu.SetActive(true);
        startButton.gameObject.SetActive(true);

        start_menu_video_player.Play();

        //myVideoPlayer.loopPointReached -= StartNewClip;
    }

    void CheckForLastFrame(VideoPlayer videoPlayer, long frame)
    {
        Debug.Log("vidPlayer.frame = " + videoPlayer.frame + ", frame = " + frame);
        if (frame == 15)
            videoPlayer.frame = 1;
    }

    public void OnStartButtonClick()
    {
        Debug.Log("start button click registered!");
    }

   
}
