using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config", menuName = "Configuration", order = 51)]
public class Config : ScriptableObject
{
    public string className;
    public List<int> id;
    [SerializeField] private List<string> houseName;
    [SerializeField] private List<Vector3> location;
    [SerializeField] private List<float> cost;
    [SerializeField] private List<int> number_of_apartments;
    [SerializeField] private int listID;
    [SerializeField] private Color color;

    public Color Color {
        get {
            return color;
        }
    }
    public int ListID {
        set {
            listID = value;
        }
    }
    public int Id {
        get {
            return id[listID];
        }
        set {
            listID = value;
        }
    }
    public string HouseName {
        get {
            return houseName[listID];
        }
    }
    public float Cost {
        get {
            return cost[listID];
        }
    }
    public int Number_of_Apartments {
        get {
            return number_of_apartments[listID];
        }
    }
    public Vector3 Location {
        get {
            return location[listID];
        }
    }
}
