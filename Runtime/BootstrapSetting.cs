using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LLib
{
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

    
        [SerializeField] private List<BootstrapEntry> _entries;

    
        public List<BootstrapEntry> Entries => _entries;
    }
}
