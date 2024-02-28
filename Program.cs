﻿
using Matrisler;

//int [,] X = Matris.Olustur(4,6,2,20);

//int [,] X = Matris.SifirMatrisiOlustur(3,3);

//int [,] X = Matris.BirlerMatrisiOlustur(4,4);

//int [,] X = Matris.KosegenMatrisOlustur(4,3,14);

//int [,] X = Matris.SkalerMatrisOlustur(4,9);

//int [,] X = Matris.BirimMatrisOlustur(4);

//System.Console.WriteLine("{0}", Matris.BirimMatrisMi(X) ? "Birim Matris" : "Birim Matris değil");

int [,] X = Matris.Olustur(3,3);

int [] D = Matris.DiyagonelElemanlarinListesi(X);

Matris.Yazdir(X);
Matris.Yazdir(D);
System.Console.WriteLine("Matrisin izi: {0}", Matris.Izi(X));

int[,] T = Matris.Transpoz(X);
Matris.Yazdir(T);



