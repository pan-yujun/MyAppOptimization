using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIClick : MonoBehaviour
{

    public TextMeshProUGUI text1;
    public Button btn1;
    public Button btn2;

    // Start is called before the first frame update
    void Start()
    {
        btn1.onClick.AddListener(OnBtn1Click);//监听点击事件
        btn2.onClick.AddListener(OnBtn2Click);//监听点击事件
    }

    private void OnBtn1Click()
    {
        Debug.Log("OnBtn1Click");
    }

    int count = 0;
    private void OnBtn2Click()
    {
        Debug.Log("OnBtn2Click");
        count++;
        if (count % 2 == 1)
        {
            btn2.GetComponent<CanvasGroup>().alpha = 0;
        }
        else
        {
            btn2.GetComponent<CanvasGroup>().alpha = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        btn1.onClick.RemoveListener(OnBtn1Click);//监听点击事件
        btn2.onClick.RemoveListener(OnBtn2Click);//监听点击事件
    }
}
