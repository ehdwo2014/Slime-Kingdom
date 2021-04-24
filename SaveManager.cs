using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System;


public static class SaveManager
{
   public static void Save(Saver data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Path.Combine(Application.persistentDataPath, "SaveData");
        FileStream stream = File.Create(path);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static Saver Load()
    {
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Application.persistentDataPath, "SaveData");
            FileStream stream = File.OpenRead(path);
            Saver data = (Saver)formatter.Deserialize(stream);
            stream.Close();
            return data;
        }
        catch(Exception e)
        {
            Debug.Log(e.Message);
            return default;
        }


     
    }

}
