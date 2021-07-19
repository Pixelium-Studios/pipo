using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    private bool is_first_update = true;

    private void Awake() {
        Debug.Log("is awake 1st??");
    }

    // Start is called before the first frame update
    void Start() {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update() {
        if (this.is_first_update) {
            this.is_first_update = false;
            Debug.Log("first update");
        }
    }

    private void FixedUpdate() {
        
    }
}
