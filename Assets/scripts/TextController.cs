using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using LitJson;

public class TextController : MonoBehaviour {

    public Text text;
    private JsonData gameText;
    private GameObject introMenuObj;
    private IntroMenuController introMenuCtrl;

    // Use this for initialization
    void Start () {
        introMenuObj = GameObject.Find("MainControllerScript");
        introMenuCtrl = introMenuObj.GetComponent<IntroMenuController>();

        setupTranslations();
        text.text = (string) gameText["intro1"];

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.V))
        {

        }
	}

    void setupTranslations() {
        switch (introMenuCtrl.language)
        {
            case "english":
                gameText = introMenuCtrl.enJsonData;
                break;

            case "spanish":
                gameText = introMenuCtrl.esJsonData;
                break;
        }
    }
}
