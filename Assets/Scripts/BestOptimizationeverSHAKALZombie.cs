using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class BestOptimizationeverSHAKALZombie : MonoBehaviour
{
    /// <summary>
    /// Загрузка текстуры из файла из контента
    /// </summary>
    /// <param name="shortPath">Короткий путь к картинке из json. Пример: "skins/1234.jpg".</param>
    /// <param name="callback">Коллбек, который принимает в себя текстуру, которую мы получим в результате выполнения этого метода.</param>
    public static IEnumerator LoadTextureMMZombie(string shortPath, RawImage rawImageZombie)
    {
        //Получаем обозначение расширения файла. Тут важно понимать, что в файлах с нового контента расширение ничего не значит.
        //Оно нужно только для нас, чтобы определить использовал ли исходник картинки альфа канал.
        //Все изображения использующие альфа канал имеют расширение png. Остальные - jpeg/jpg.
        int lastIndexOfDotZombie = shortPath.LastIndexOf(".", StringComparison.Ordinal);
        int prefixLengthZombie = shortPath.Length - lastIndexOfDotZombie;

        string postfixZombie = shortPath.Substring(lastIndexOfDotZombie, prefixLengthZombie);

        string filePathZombie = shortPath;
       
        //Получаем путь к файлу на устройстве. Предварительно его нужно было скачать в эту директорию.
        //Если у вас путь генерируется как-то иначе - смело меняйте эту строчку.
        //string filePathZombie = Application.persistentDataPath + "/Minecraft/" + shortPath;
        //if (!shortPath.Contains(Application.persistentDataPath))
        //{
        //    filePathZombie = Application.persistentDataPath + shortPath;
        //}

        if (rawImageZombie != null)
        {
            Debug.Log("shortPath");
            string[] s = shortPath.Split("TestGetTexture");
            rawImageZombie.gameObject.name = s[1];
        }

        var readingTaskZombie = File.ReadAllBytesAsync(filePathZombie);
        //Debug.Log("shortPath " + shortPath + " rawImageZombie " + rawImageZombie.gameObject.name);
        while (!readingTaskZombie.IsCompleted)
        {
            yield return null;
        }
       
        //Считанные данные записываем в масив байт.
        byte[] dataZombie = readingTaskZombie.Result;

        //В последние 8 байт записана информация о изначальном разрешении картинки. Считываем ее.
        byte[] widthByteZombie = new byte[] { dataZombie[dataZombie.Length - 8], dataZombie[dataZombie.Length - 7], dataZombie[dataZombie.Length - 6], dataZombie[dataZombie.Length - 5] };
        byte[] heighthByteZombie = new byte[] { dataZombie[dataZombie.Length - 4], dataZombie[dataZombie.Length - 3], dataZombie[dataZombie.Length - 2], dataZombie[dataZombie.Length - 1] };


        int widthZombie = BitConverter.ToInt32(widthByteZombie);
        int heightZombie = BitConverter.ToInt32(heighthByteZombie);

        Texture2D tex2DmmZombie;
        if (postfixZombie == ".png")
            tex2DmmZombie = new Texture2D(widthZombie, heightZombie, TextureFormat.ETC2_RGBA8, false);
        else
            tex2DmmZombie = new Texture2D(widthZombie, heightZombie, TextureFormat.ETC2_RGB, false);


        //float alphaChannelCoefficient = (float)((dataZombie.Length - 8) * 6) / (float)(widthZombie * heightZombie * 6);
        //if (alphaChannelCoefficient < 1)
        //    tex2DmmZombie = new Texture2D(widthZombie, heightZombie, TextureFormat.ETC2_RGB, false);
        //else
        //    tex2DmmZombie = new Texture2D(widthZombie, heightZombie, TextureFormat.ETC2_RGBA8, false);

        tex2DmmZombie.LoadRawTextureData(dataZombie);

        tex2DmmZombie.Apply(false, false);
        if (rawImageZombie != null)
        {
            rawImageZombie.texture = tex2DmmZombie;
            rawImageZombie.SetNativeSize();
            rawImageZombie.gameObject.name = "all ok";
        }

        //callback?.Invoke(tex2DmmZombie, rawImageZombie);
    }
}
