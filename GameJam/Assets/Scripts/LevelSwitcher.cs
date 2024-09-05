using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSwitcher : MonoBehaviour
{
    public GameObject switchPanel;
    // Start is called before the first frame update
    void Start()
    {
        switchPanel.SetActive(false);
    }

    // Update is called once per frame
    public void OnPlayerInteract() 
    {
        switchPanel.SetActive(true);
    }

    public void OnYesButtonClicked()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void OnNoButtonClicked() 
    {
        switchPanel.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject);
        if (other.CompareTag("Player"))
        {
            OnPlayerInteract();
        }
    }
}
