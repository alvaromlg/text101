using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;

    // Use this for initialization
    void Start () {
        GameObject introMenuObj = GameObject.Find("MainControllerScript");
        IntroMenuController introMenuCtrl = introMenuObj.GetComponent<IntroMenuController>();

        Debug.Log(introMenuCtrl.language);

        //switch (introMenuCtrl.language == "english")
    
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.V))
        {

        }
	}
}
