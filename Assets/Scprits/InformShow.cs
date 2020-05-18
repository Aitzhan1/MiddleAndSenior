using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformShow : MonoBehaviour
{
    public Config config;
    public Text infoText;
    public Text className;
    public Dropdown dropdown;
    private void OnMouseEnter()
    {
        className.text = config.className;
    }
    private void OnMouseExit()
    {
        className.text = null;
    }
    private void OnMouseDown()
    {
        if (dropdown.gameObject.activeSelf)
        {
            dropdown.gameObject.SetActive(false);
            dropdown.value = 0;
            infoText.text = "";
        }
        else
        {
            dropdown.gameObject.SetActive(true);
            for (int i = 0; i < config.id.Count; i++)
            {
                if (int.Parse(gameObject.name) == i)
                {
                    config.ListID = i;
                    infoText.text = config.Cost.ToString();
                }
            }
        }  
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public void HandleInputData(int val)
    {
        if (val == 0)
        {
            for (int i = 0; i < config.id.Count; i++)
            {
                if (int.Parse(gameObject.name) == i)
                {
                    config.ListID = i;
                    infoText.text = config.Cost.ToString();
                }
            }  
        }
        if (val == 1)
        {
            for (int i = 0; i < config.id.Count; i++)
            {
                if (int.Parse(gameObject.name) == i)
                {
                    config.ListID = i;
                    infoText.text = config.Number_of_Apartments.ToString();
                }
            }
        }
    }

}
