using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try//hataya neden olabilecek kod yazılır.
            {
                Console.WriteLine("Bir sayı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
            }
            catch(Exception ex) //ex bir obje. hata ile karşılaşıldığında ne yapılacağı yazılır. 
            {
                Console.WriteLine("Hata :" + ex.Message.ToString());
                //Hata: Input string was not in a correct format.
            }

            /*finally//hata fark etmeksizin yapmak istenilen işi yapar.
            {
                Console.WriteLine("İşlem tamamlandı.");
            }*/

            //boş değer, ilgili veriye göre hata mesajı için:
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
