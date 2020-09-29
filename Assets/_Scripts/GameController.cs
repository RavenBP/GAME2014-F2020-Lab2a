using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(869.0f, -82.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(130.0f, -82.0f);
                //SceneLabel.text = "Landscape left";
                break;
            case DeviceOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(721.0f, -82.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(130.0f, -82.0f);
                //SceneLabel.text = "Landscape right";
                break;
            case DeviceOrientation.Portrait:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(721.0f, -164.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(130.0f, -164.0f);
                //SceneLabel.text = "Portrait";
                break;
            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknown orientation";
                break;
        }
    }
}
