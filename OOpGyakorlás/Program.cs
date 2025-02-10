using OOPgyakorlas;

namespace OOpGyakorlás
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new Konyv("A kis herceg", "Antonia", 1943 ,2500 , 96);
			Konyv konyv2 = new("Ez meg keszul", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());


			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);

            Console.WriteLine();
            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.HanyOldalMaradt(20));
			

			Film film1 = new Film("A kis herceg", "Antonia", 1943, "Fantasy", true);
            Film film2 = new("Ez meg keszul", "Én");
            Console.WriteLine(film1.ToString() + "\n" + film2.ToString());
			Console.WriteLine();

        }
	}
}
