using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PlayerInput : MonoBehaviour
{
    public PlayerInput playerInput;
    public Text Txt_CurrentPos;
    public Text Txt_ClickPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Txt_CurrentPos.text = playerInput.currentPos;
        Txt_ClickPos.text = playerInput.clickPos;
    }
}
