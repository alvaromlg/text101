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
        // Load translations from XML locale files
        enJsonStr = File.ReadAllText(Application.dataPath + "/locale/english.json");
        esJsonStr = File.ReadAllText(Application.dataPath + "/locale/spanish.json");

        // Parse JSON string into JSON object
        enJsonData = JsonMapper.ToObject(enJsonStr);
        esJsonData = JsonMapper.ToObject(esJsonStr);
    }
	
    void Awake()
    {
        // We need to keep it alive so we dont lose locale variables
        DontDestroyOnLoad(transform.gameObject);
    }

    public void ClickEs()
    {
        language = "spanish";
        SceneManager.LoadScene("Game");
    }

    public void ClickEn()
    {
        language = "english";
        SceneManager.LoadScene("Game");
    }


}
