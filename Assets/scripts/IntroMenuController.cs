using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;
using LitJson;

public class IntroMenuController : MonoBehaviour {

    private string enJsonStr;
    private string esJsonStr;
    public JsonData enJsonData;
    public JsonData esJsonData;
    public string language = "spanish";

	// Use this for initialization
	void Start () {
        // Load translations
        enJsonStr = File.ReadAllText(Application.dataPath + "/locale/english.json");
        esJsonStr = File.ReadAllText(Application.dataPath + "/locale/spanish.json");

        // Parse JSON string into JSON object
        enJsonData = JsonMapper.ToObject(enJsonStr);
        esJsonData = JsonMapper.ToObject(esJsonStr);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void ClickEs()
    {
        Debug.Log("Spanish");
        language = "spanish";
        SceneManager.LoadScene("Game");
    }

    public void ClickEn()
    {
        Debug.Log("English");
        language = "english";
        SceneManager.LoadScene("Game");
    }


}
