using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordscr : MonoBehaviour
{
    public int record;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (record < Score.score)
        {
            PlayerPrefs.SetInt("savescore", Score.score);
            PlayerPrefs.Save();
          
        }
        record = PlayerPrefs.GetInt("savescore");
        GetComponent<UnityEngine.UI.Text>().text = record.ToString();
    }
}
