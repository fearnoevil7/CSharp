using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace utilities.sessionextensions
{
    // public static class SessionExtensions
    // {
    //     public static void SetObjectAsJson( string key, object value)
    //     {
    //     session.SetString(key, JsonConvert.SerializeObject(value));
    //     }

    //     public static T GetObjectFromJson<T>( string key)
    //     {
    //         string value = session.GetString(key);
    //         return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    //     }
    // }
}