﻿using System;
using System.IO;
using System.Text.Json;
public class DataMahasiswa1302220078
{
    public class Nama
    {
        public String depan { get; set; }
        public String belakang { get; set; }
    }
    public Nama nama { get; set; }
    public int nim { get; set; }
    public String fakultas { get; set; }

    public void ReadJSON()
    {
        string filePath = "tp7_1_1302220078.json";

        string jsonText = File.ReadAllText(filePath);

        DataMahasiswa1302220078 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220078>(jsonText);

        Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan NIM {dataMahasiswa.nim} dari Fakultas {dataMahasiswa.fakultas}");
    }
}
