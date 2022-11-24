/*
 * Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
 * 
 *  [x] void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto
 *  dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
 *  
 *  [x] int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
 *  
 *  [x] int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array
 *  con tutti gli elementi elevati quadrato.
 *  
 *  [x] int sommaElementiArray(int[] array): che preso un array di numeri interi,
 *  restituisca la somma totale di tutti gli elementi dell’array.
 *
 *
 *
 * Una volta completate queste funzioni di utilità di base, e dato
 * il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
 * 
 *  [x] Stampare l’array di numeri fornito a video
 *  
 *  [x] Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
 *  (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale
 *  e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
 *  
 *  [x] Stampare la somma di tutti i numeri
 *  
 *  [x] Stampare la somma di tutti i numeri elevati al quadrati
 */

using Utilities;

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

arrayNumeri.StampaArrayInteri();
arrayNumeri.ElevaArrayAlQuadrato().StampaArrayInteri();
arrayNumeri.StampaArrayInteri();
Console.WriteLine(arrayNumeri.SommaElementiArray());
Console.WriteLine(arrayNumeri
    .ElevaArrayAlQuadrato()
    .SommaElementiArray());