using UnityEngine;

public class OpeningAnimationStarter : MonoBehaviour
{
    [SerializeField]
    private GameObject openingAnimationPanel;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("InvokedFunction",2f);
    }

    void InvokedFunction()
    {
        openingAnimationPanel.SetActive(true);
    }

   
}
