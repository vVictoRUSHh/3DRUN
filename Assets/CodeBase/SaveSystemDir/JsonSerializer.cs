﻿using UnityEngine;
namespace CodeBase.SaveSystemDir
{
    public class JsonSerializer //IJsonSerializer
    {
        public string Serialize<T>(T obj)
        {
            return JsonUtility.ToJson(obj,true);
        }
       public T Deserialize<T>(string json)
        {
            return JsonUtility.FromJson<T>(json);
        }
    }
}