﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOpGyakorlás
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadasEve;
		private int ar;
		private int oldalszam;
		/// <summary>
		/// Feladat leirás
		/// </summary>
		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
		public int Ar { get => ar; set => ar = value; }
		public int Oldalszam { get => oldalszam; set => oldalszam = value; }

		public Konyv(string cim, string szerzo, int kiadasEve, int ar, int oldalszam)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEve = kiadasEve;
			this.ar = ar;
			this.oldalszam = oldalszam;
		}

		public Konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			kiadasEve = DateTime.Now.Year;
			oldalszam = 200;
			ar = 3000;
		}

		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}
		public void Kedvezmeny(double szazalek)
		{
			ar -= Convert.ToInt16(ar * (szazalek / 100));

		}

		public int HanyOldalMaradt(int elolvasott)
		{
			return oldalszam - elolvasott;
		}

		public override string? ToString()
		{
			return $"{this.Cim} - {this.Szerzo} / {this.Oldalszam} / {this.KiadasEve} - {this.Ar}";
		}
	}
}
