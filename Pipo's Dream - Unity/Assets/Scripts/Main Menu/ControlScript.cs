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
    
    // Start is called before the first frame update
    void Start()
    {
        loading_video_player.loopPointReached += StartNewClip;

        // do delayed start ( zbog onih vizualnih problema pri Play-anju Unity programa )

        // izgleda da nije dovoljno staviti delay pa onda SetActive na cijeli panel, i dalje "freeza" neki frame iz videa kad se aktivira panel pa onda krene playati normalno
        // mozda playati video a imati "deaktiviran" Image, pa "pecati" tajming da se aktivira taman kad se video pocne "normalno playati"
        Invoke("InvokedFunction", initialPlayDelay);    
    }

    void InvokedFunction()
    {
        video_panel_loading.SetActive(true);
        loading_video_player.Play();
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

    public void OnStartButtonClick()
    {
        Debug.Log("start button click registered!");
    }

   
}
