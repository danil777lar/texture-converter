using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class LoadTexturesZombie
{
    /// <summary>
    /// Загрузка текстуры из файла из контента
    /// </summary>
    /// <param name="shortLocalPathZombie">Короткий путь к картинке из json. Пример: "skins/1234.jpg".</param>
    /// <param name="callbackZombie">Коллбек, который принимает в себя текстуру, которую мы получим в результате выполнения этого метода.</param>
    public static void LoadLocalTextureZombie(string shortLocalPathZombie, RawImage rawImageZombie)
    {
        //Debug.Log(" shortLocalPathZombie " + shortLocalPathZombie);
        //string filePathZombie = Application.persistentDataPath + shortLocalPathZombie;

        byte[] dataZombie = File.ReadAllBytes(shortLocalPathZombie);


        //В последние 8 байт записана информация о изначальном разрешении картинки. Считываем ее.
        byte[] widthByteZombie = new byte[] { dataZombie[dataZombie.Length - 8], dataZombie[dataZombie.Length - 7], dataZombie[dataZombie.Length - 6], dataZombie[dataZombie.Length - 5] };
        byte[] heighthByteZombie = new byte[] { dataZombie[dataZombie.Length - 4], dataZombie[dataZombie.Length - 3], dataZombie[dataZombie.Length - 2], dataZombie[dataZombie.Length - 1] };

        //Переводим считанное разрешение в человеческий вид
        int widthZombie = BitConverter.ToInt32(widthByteZombie);
        int heightZombie = BitConverter.ToInt32(heighthByteZombie);
        Texture2D tex2DmmZombie;

        Debug.Log("widthZombie " + widthZombie + " heightZombie " + heightZombie + " shortLocalPathZombie" + shortLocalPathZombie);
       
        float alphaChannelCoefficient = (float)((dataZombie.Length - 8) * 6) / (float)(widthZombie * heightZombie * 6);
        if (alphaChannelCoefficient < 1)
            tex2DmmZombie = new Texture2D(widthZombie, heightZombie, TextureFormat.ETC2_RGB, false);
        else
            tex2DmmZombie = new Texture2D(widthZombie, heightZombie, TextureFormat.ETC2_RGBA8, false);


        tex2DmmZombie.LoadRawTextureData(dataZombie);
        tex2DmmZombie.Apply(false, false);
       
        rawImageZombie.texture = tex2DmmZombie;
        rawImageZombie.SetNativeSize();
    }
}
