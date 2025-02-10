using OOPgyakorlas;

namespace OOpGyakorlás
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Konyv konyv1 = new Konyv("A kis herceg", "Antonia", 1943 ,2500 , 96);
			//Konyv konyv2 = new("Ez meg keszul", "Én");

   //         Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());


			//konyv1.Kedvezmeny(20);
			//konyv1.Arnoveles(1000);

   //         Console.WriteLine();
   //         Console.WriteLine(konyv1.ToString() + "\n" + konyv2.HanyOldalMaradt(20));
			

			//Film film1 = new Film("A kis herceg", "Antonia", 1943, "Fantasy", true);
   //         Film film2 = new("Ez meg keszul", "Én");
   //         Console.WriteLine(film1.ToString() + "\n" + film2.ToString());
			//Console.WriteLine();

			//Videojatek jatekos = new Videojatek("Ferencz", 100);
   //         Videojatek jatekos2 = new("Béla", 200);
   //         Console.WriteLine(jatekos.ToString() + "\n" + jatekos2.ToString());
			//Videojatek jatekos3 = new Videojatek("lovag", 100, 100, 100);
   //         Videojatek jatekos4 = new("kardos", 200, 200, 200);
			//jatekos.Gyogyulas(20);
			//jatekos2.SzintLepes();
			//jatekos3.Tamadas();
   //         Console.WriteLine(jatekos3.ToString() + "\n" + jatekos4.ToString());
   //         Console.WriteLine(jatekos);
   //         Console.WriteLine(jatekos2);


			Urhajo spaceX = new Urhajo("Tesla", 100, 20, 100);

            Console.WriteLine(spaceX);
            Console.WriteLine("A Tesla megálllt tankolni");
			spaceX.Tankolas(20); //Megtankoltam
            Console.WriteLine(spaceX);

			Urhajo Testhajo = new Urhajo("RobotImre", 1000);
            Console.WriteLine(Testhajo);
            Console.WriteLine("A TestHajo Elindul");
			Testhajo.Indulas();
            Console.WriteLine(Testhajo);
			Testhajo.Landolas();
            Console.WriteLine(Testhajo);
            Console.WriteLine("Landolt");



        }
	}
}
