public class main
{
    public static void Main(string[] args)
    {
        DataMahasiswa1302223051 mahasiswa1302223051 = new DataMahasiswa1302223051();

        mahasiswa1302223051.ReadJSON();

        KuliahMahasiswa1302223051 kuliah1302223051 = new KuliahMahasiswa1302223051();

        kuliah1302223051.ReadJSON();
    }
}