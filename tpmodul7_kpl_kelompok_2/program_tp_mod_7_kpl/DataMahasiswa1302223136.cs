using System;
using System.IO;
using System.Text.Json;
public class DataMahasiswa1302223136
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
        string filePath = "tp7_1_1302223136.json";

        string jsonText = File.ReadAllText(filePath);

        DataMahasiswa1302223136 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223136>(jsonText);

        Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan NIM {dataMahasiswa.nim} dari Fakultas {dataMahasiswa.fakultas}");
    }
}
