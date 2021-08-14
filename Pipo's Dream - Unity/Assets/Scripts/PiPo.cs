using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiPo : MonoBehaviour {
    private SpriteRenderer sprite_renderer;
    [SerializeField] 
    private int speed = 5;
    
    // Start is called before the first frame update
    void Start() {
        this.sprite_renderer = this.GetComponent<SpriteRenderer>();
        // a sad je promijenjen
    }

    // Update is called once per frame
    void Update() {
        var pos = this.transform.position;
        var x = pos.x + PiPo.getInputLR() * this.speed * Time.deltaTime;
        this.transform.position = new Vector3(x, pos.y, pos.z);
    }
    
    /**
     * float between -1 and +1 including
     * -1 left  +1 right
     * indicating tilt of the phone
     */
    static float getInputLR() {
        // TODO: change from key press to tilt
        // return Input.acceleration.x; // tilt
        return 
            (Input.GetKey(KeyCode.RightArrow) ? 1 : 0)
           -(Input.GetKey(KeyCode.LeftArrow)  ? 1 : 0)
        ;
    }
}
