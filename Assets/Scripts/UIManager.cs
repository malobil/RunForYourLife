using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIElement { GameOver}

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private UIObject[] UIElements ;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHideUI(UIElement UIToShow, bool show)
    {
        for(int i = 0; i < UIElements.Length; i++)
        {
            if(UIToShow == UIElements[i].elem)
            {
                UIElements[i].uiObject.SetActive(show);
                return;
            }
        }
    }
}

[System.Serializable]
public class UIObject
{
    public UIElement elem;
    public GameObject uiObject;
}
