using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum UIElement { GameOver, Victory, LifeBar}

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private UIObject[] UIElements ;
    [SerializeField] private string m_mainMenu = "MainMenu" ;
    [SerializeField] private Image m_lifeBar;

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

    public void UpdateLifeUI(float actualValue, float maxValue)
    {
        m_lifeBar.fillAmount = actualValue/maxValue ;
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

    public void ReplayButton()
    {
        CharacterMovement.Instance.ResetInputs();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ContinueButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            CharacterMovement.Instance.ResetInputs();
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    public void QuitButton()
    {
        CharacterMovement.Instance.ResetInputs();
        SceneManager.LoadScene(m_mainMenu);
    }
}

[System.Serializable]
public class UIObject
{
    public UIElement elem;
    public GameObject uiObject;
}
