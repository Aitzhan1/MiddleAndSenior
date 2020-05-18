using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateHouse : MonoBehaviour
{
    public List<Config> config;
    public List<GameObject> prefab;
    public List<GameObject> house;
    public List<Toggle> select_House;
    void Start()
    {
        for (int i = 0; i < config[0].id.Count; i++)
        {
            //Create Economy house
            config[0].ListID = i;
            GameObject obj_0=Instantiate(prefab[0], config[0].Location, Quaternion.identity);
            house.Add(obj_0);
            obj_0.name = i.ToString();
            obj_0.GetComponent<MeshRenderer>().material.color = config[0].Color;

            //Create Comfort house
            config[1].ListID = i;
            GameObject obj_1=Instantiate(prefab[1], config[1].Location, Quaternion.identity);
            house.Add(obj_1);
            obj_1.name = i.ToString();
            obj_1.GetComponent<MeshRenderer>().material.color = config[1].Color;

            //Create Premium house
            config[2].ListID = i;
            GameObject obj_2 = Instantiate(prefab[2], config[2].Location, Quaternion.identity);
            house.Add(obj_2);
            obj_2.name = i.ToString();
            obj_2.GetComponent<MeshRenderer>().material.color = config[2].Color;  
        }
    }

    private void Update()
    {
        if (!select_House[0].isOn)
        {
            for (int i = 0; i < house.Count; i++)
            {
                if (house[i].tag == "Economy")
                {
                    house[i].SetActive(false);
                }
            }
        }
        else
        {
            for (int i = 0; i < house.Count; i++)
            {
                if (house[i].tag == "Economy")
                {
                    house[i].SetActive(true);
                }
            }
        }
        if (!select_House[1].isOn)
        {
            for (int i = 0; i < house.Count; i++)
            {
                if (house[i].tag == "Comfort")
                {
                    house[i].SetActive(false);
                }
            }
        }
        else
        {
            for (int i = 0; i < house.Count; i++)
            {
                if (house[i].tag == "Comfort")
                {
                    house[i].SetActive(true);
                }
            }
        }
        if (!select_House[2].isOn)
        {
            for (int i = 0; i < house.Count; i++)
            {
                if (house[i].tag == "Premium")
                {
                    house[i].SetActive(false);
                }
            }
        }
        else
        {
            for (int i = 0; i < house.Count; i++)
            {
                if (house[i].tag == "Premium")
                {
                    house[i].SetActive(true);
                }
            }
        }
    }

}
