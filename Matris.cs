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

        public static void Yazdir (int [] X)
        {
         for (int i = 0; i < X.Length; i++)
         {
            System.Console.WriteLine();
            System.Console.Write("{0,5}", X[i]);
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
    /// <summary>
    /// Skaler matris oluşturur
    /// </summary>
    /// <param name="boyut">Satır ve sutun</param>
    /// <param name="skaler">Kösegenler üstundeki değer</param>
    /// <returns>skaler matrisi temsil eder</returns>
    public static int [,] SkalerMatrisOlustur (int boyut =3, int skaler=3)
    {
        return KosegenMatrisOlustur(boyut,skaler,skaler);
    }
/// <summary>
/// Kare Matris Kontrolu yapar
/// </summary>
/// <param name="X">Matris</param>
/// <returns>Sonuc</returns>
    public static bool KareMatrisMi (int [,] X)
    {
        return X.GetLength(0)==X.GetLength(1) ? true : false;
    }

    public static int [,] BirimMatrisOlustur (int boyut=3)
    {
        return SkalerMatrisOlustur (boyut, 1);
    }

    public static bool BirimMatrisMi (int [,] X)
    {
        bool s = true;
        for (int i = 0; (i<X.GetLength(0)&& s==true); i++)
        {
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i,j]!=0 && i!=j)
                {
                    s = false;
                    break;
                }
                else if (X[i,i]!=1 && i==j )
                {
                    s = false;
                    break;
                }
            }
           
        }
        return s;
    }  

    /// <summary>
    /// Diyagonel elemanların listesini bir dizi olarak doner
    /// </summary>
    /// <param name="X">Matrisi</param>
    /// <returns>Diyagonel elemanların listesi</returns>
    public static int [] DiyagonelElemanlarinListesi ( int [,] X)
    {
        if (KareMatrisMi(X))
        {
            int [] D = new int[X.GetLength(0)];
            for (int i = 0; i < X.GetLength(0); i++)
                D[i] = X [i,i];
            return D;            
        }
        else
        {
            System.Console.WriteLine("Lütfen Kare Matris giriniz!");
            return new int [1];
        }
    }

/// <summary>
/// Bir Matrisin İzini hesaplar
/// </summary>
/// <param name="X">Matris</param>
/// <returns>İzi</returns>
    public static int Izi (int [,] X)
    {
        int t =0;
        if (KareMatrisMi(X))
        {
            int [] D = DiyagonelElemanlarinListesi (X);
            for (int i = 0; i < X.GetLongLength(0); i++)
            t+=X[i,i];
            return t;              
        }
        else
        return t;
                 
    }
    /// <summary>
    /// Bir Matrisin Transpozunu alır
    /// </summary>
    /// <param name="X">Matris</param>
    /// <returns>Transpoz</returns>
    public static int [,] Transpoz (int[,] X)
    {
        int[,] T = new int[X.GetLength(1), X.GetLength(0)];
        for (int i = 0; i < T.GetLength(0); i++)
            for (int j = 0; j < T.GetLength(1); j++)
                T[i,j] = X[j,i];
        return T;
        
    }


}
