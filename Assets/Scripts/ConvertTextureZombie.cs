using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ConvertTextureZombie : MonoBehaviour
{
    public string PathForDirectoryToTexture;


    [ContextMenu("Convert")]
    async void Convert()
    {
        List<string> filesPathZombie = Directory.GetFiles(Application.persistentDataPath + "/" + PathForDirectoryToTexture).ToList();

        foreach (var filePath in filesPathZombie)
        {
            StartCoroutine(ConvertZombie(filePath));
            await Task.Delay(50);
        }
    }

    private IEnumerator ConvertZombie(string imagePath)
    {
        var readingTaskZombie = File.ReadAllBytesAsync(imagePath);

        while (!readingTaskZombie.IsCompleted)
        {
            yield return null;
        }

        byte[] dataZombie = readingTaskZombie.Result;

        Texture2D textureZombie = new Texture2D(4, 4, TextureFormat.RGB24, false);

        textureZombie.LoadImage(dataZombie);

        if (textureZombie.width % 4 != 0 || textureZombie.height % 4 != 0)// если при делении на 4 высоты или ширины текстуры есть остатакок
        {
            int sizeXZombie = textureZombie.width - textureZombie.width % 4;//отнимаем остаток от ширины
            int sizeYZombie = textureZombie.height - textureZombie.height % 4;//отнимаем остаток от высоты
            var newPixelsZombie = textureZombie.GetPixels(0, 0, sizeXZombie, sizeYZombie);//сохраняем пиксели текстуры размером кратным 4
            textureZombie.Reinitialize(sizeXZombie, sizeYZombie);//меняем размер текстуры кратным 4
            textureZombie.SetPixels(newPixelsZombie);//перезаписываем пиксели
            textureZombie.Apply(false, false);//сохраняем изменения
        }

        textureZombie.Compress(false);
        textureZombie.Apply(false, false);

        Debug.Log("Compressed");

        //Получаю из текстуры массив байтов
        byte[] dataBytesZombie = textureZombie.GetRawTextureData();

        //Делаю новый массив на 8 байтов больше
        byte[] dataBytesWithSizeZombie = new byte[dataBytesZombie.Length + 8];
        //...копирую в него предыдущий
        Array.Copy(dataBytesZombie, dataBytesWithSizeZombie, dataBytesZombie.Length);

        //Перегоняю ширину и высоту в байтовые массивы
        byte[] widthZombie = BitConverter.GetBytes(textureZombie.width);
        byte[] heightZombie = BitConverter.GetBytes(textureZombie.height);


        //запиываю в последние 8 байт последнего массива высоту и ширину побайтово
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 8] = widthZombie[0];
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 7] = widthZombie[1];
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 6] = widthZombie[2];
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 5] = widthZombie[3];
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 4] = heightZombie[0];
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 3] = heightZombie[1];
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 2] = heightZombie[2];
        dataBytesWithSizeZombie[dataBytesWithSizeZombie.Length - 1] = heightZombie[3];


        if (!File.Exists($"{Application.persistentDataPath}/ReadyTexture"))
        {
            Directory.CreateDirectory($"{Application.persistentDataPath}/ReadyTexture");
        }

        string filePathToSaveZombie = $"{Application.persistentDataPath}/ReadyTexture/{Path.GetFileName(imagePath)}";

        //Сохраняю файл
        File.WriteAllBytes(filePathToSaveZombie, dataBytesWithSizeZombie);
    }
}
