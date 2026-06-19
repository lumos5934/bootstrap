using System;
using UnityEngine;

namespace LLib
{
    [Serializable]
    public class BootstrapEntry
    {
        [SerializeField] bool _dontDestroy;
        [SerializeField] GameObject _prefab;

        public GameObject Prefab => _prefab;
        public bool DontDestroy => _dontDestroy;
    }
}

