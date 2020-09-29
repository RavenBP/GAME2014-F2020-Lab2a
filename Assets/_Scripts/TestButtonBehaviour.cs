using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text SceneLabel;
    public TMP_Text ScoreLabel;
    public TMP_Text LivesLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        LivesLabel.rectTransform.anchoredPosition = new Vector3(869.0f, -82.0f, 0.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector3(130.0f, -82.0f, 0.0f);
    }
}
