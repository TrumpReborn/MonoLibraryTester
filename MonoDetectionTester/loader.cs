using System;
using System.Reflection;
using UnityEngine;


namespace MonoDetectionTester
{
    public class loader 
    { 
        public static void Initialize()
        {
            
            GO.AddComponent<Drawing>();
            UnityEngine.Object.DontDestroyOnLoad(loader.GO);
            
        }
        public static GameObject GO = new GameObject();
     
    }
  
}
