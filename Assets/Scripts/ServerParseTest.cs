using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ServerParseTest : MonoBehaviour
{
    public List<string> list = new List<string>();

    private void Awake()
    {
        parse();
    }
    private void parse()
    {
        //string path = @"Assets/Scripts/Servers.json";
        string path = Application.persistentDataPath + "/" + "Servers.json";
        Debug.Log("path " + path);
        List<ServersContent> listServers = JsonConvert.DeserializeObject<List<ServersContent>>(File.ReadAllText(path));
        foreach (var item in listServers)
        {
            list.Add(item.Cpz9F);
        }
    }

}
