namespace Matrisler;

public class Matris
{
   /// <summary>
   /// Matris oluşturur
   /// </summary>
   /// <param name="satir">Satır sayısı</param>
   /// <param name="sutun">Sutun sayısı</param>
   /// <param name="min">Min Deger</param>
   /// <param name="max">Max Deger</param>
   /// <returns>X Matrisi</returns>
    public static int [,] Olustur ( int satir=3, int sutun = 3, int min = 1, int max=9)
    {
        int [,] X = new int [satir,sutun];
        for (int i = 0; i < satir; i++)
        for (int j = 0; j< sutun; j++)
            X[i,j] = new Random().Next(min,max);

        return X;
    }
    /// <summary>
    /// Parametre olarak aldığı Matrisi ekrana yazar
    /// </summary>
    /// <param name="X"></param>
    public static void Yazdir (int [,] X)
    {
        for (int i = 0; i < X.GetLength(0); i++)
        {
            for (int j = 0; j < X.GetLength(1); j++)
              System.Console.Write("{0,5}", X[i,j]);
            System.Console.WriteLine();
        }
    }
    /// <summary>
    /// Sıfır matrisi oluşturur
    /// </summary>
    /// <param name="satir">Satır</param>
    /// <param name="sutun">Sutun</param>
    /// <returns>Sıfır Matrisi</returns>
    public static int [,] SifirMatrisiOlustur(int satir, int sutun)
    {
       return Olustur(satir,sutun,0,0);
    }

    /// <summary>
    /// Birler matrisi oluşturur
    /// </summary>
    /// <param name="satir">Satır</param>
    /// <param name="sutun">Sutun</param>
    /// <returns>Birler Matrisi</returns>
    public static int [,] BirlerMatrisiOlustur(int satir, int sutun)
    {
       return Olustur(satir,sutun,1,1);
    }

    /// <summary>
    /// Kosegen Matris Olusturur
    /// </summary>
    /// <param name="boyut">Satır ve Sutun Sayısı</param>
    /// <param name="min">Minumum değeler</param>
    /// <param name="max">Maximumum değeler</param>
    /// <returns>Kosegen Matris/returns>
    public static int [,] KosegenMatrisOlustur (int boyut=3, int min = 1, int max =9)
    {
        int [,] X = SifirMatrisiOlustur(boyut, boyut);
        for (int i = 0; i < X.GetLength(0); i++)
            X[i,i] = new Random ().Next(min , max);      
        return X;

    }

}
