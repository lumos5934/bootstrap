using System;
using UnityEngine;

[Serializable]
public class BootstrapEntry
{
    [SerializeField] bool dontDestroyOnLoad;
    [SerializeField] GameObject prefab;

    public GameObject Prefab => prefab;
    public bool DontDestroyOnLoad => dontDestroyOnLoad;
}