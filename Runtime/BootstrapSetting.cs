using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BootstrapSetting : ScriptableObject
{
    private static BootstrapSetting _instance;
    public static BootstrapSetting Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.FindObjectsOfTypeAll<BootstrapSetting>().FirstOrDefault();
            }
            
            return _instance;
        }
    }

    
    [SerializeField] private List<BootstrapEntry> entries;

    
    public List<BootstrapEntry> Entries => entries;
}