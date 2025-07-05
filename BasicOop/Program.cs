namespace BasicOop
{
	internal class OOP
	{
		//	class Animal
		//	{
		//		public string tiengKeu { get; private set; }
		//		public string cachDiChuyen { get; private set; }
		//		public string mauLong { get; private set; }

		//		public Animal()
		//		{
		//			this.tiengKeu = "gầm gừ";
		//			this.cachDiChuyen = "trên mặt đất";
		//			this.mauLong = "màu xám";
		//		}
		//		public virtual void Keu()
		//		{
		//			Console.WriteLine(tiengKeu);
		//		}

		//		public virtual void CachDiChuyenPhuongThuc()
		//		{
		//			Console.WriteLine(cachDiChuyen);
		//		}

		//		public void setTiengKeu(string tiengKeu)
		//		{
		//			this.tiengKeu = tiengKeu;
		//		}
		//		public void setCachDiChuyen(string cachDiChuyen)
		//		{
		//			this.cachDiChuyen = cachDiChuyen;
		//		}
		//		public void setMauLong(string mauLong)
		//		{
		//			this.mauLong = mauLong;
		//		}


		//	}
		//	class Lion : Animal
		//	{
		//		public override void Keu()
		//		{
		//			Console.WriteLine("hú hú");
		//		}
		//	}
		//	class Bird : Animal
		//	{
		//		public string loaiCanh { get; private set; }

		//		public Bird()
		//		{
		//			this.loaiCanh = "cánh mềm";
		//		}
		//		public override void Keu()
		//		{
		//			Console.WriteLine("chíp chíp");
		//		}
		//		public void Bay(int tocdo)
		//		{
		//			Console.WriteLine(tocdo);
		//		} 
		//		public void Bay(int tocdo, string diemden)
		//		{
		//			Console.WriteLine(tocdo + " " + diemden);
		//		} 
		//	}
		//	class Dog : Animal
		//	{
		//		public string Giong {  get; private set; }

		//		public Dog(string giong)
		//		{
		//			Giong = giong;
		//		}
		//		public override void Keu()
		//		{
		//			Console.WriteLine("gâu gâu");
		//		}
		//		public int TocDo(int quangDuong, int vanToc)
		//		{
		//			return quangDuong = vanToc / 60;
		//		}
		//		public int TocDo(int quangDuong, float vanToc)
		//		{
		//			return quangDuong = (int)vanToc / 60;
		//		}
		//	}
		//	class Fish  : Animal
		//	{
		//		public string LoaiCa {  get; private set; }

		//		public Fish(string loaiCa) : base() {
		//			LoaiCa = loaiCa;
		//		}

		//		public override void CachDiChuyenPhuongThuc()
		//		{
		//			Console.WriteLine("bơi trong nước");
		//		}
		//		public void Swim(int speed)
		//		{
		//			Console.WriteLine(speed);
		//		} 
		//		public void Swim(int speed, int direction)
		//		{
		//			Console.WriteLine($"{speed} and {direction}");
		//		} 

		//	}
		//	class Tiger : Animal
		//	{
		//		public string cachAn { get; private set; }
		//		public override void Keu()
		//		{
		//			Console.WriteLine("gào gào");
		//		}

		//	}
		//}
		abstract class Animals
		{
			public string TiengKeu { get; set; }
			public string CachDiChuyen { get; set; }
			public string MauLong { get; set; }

			protected Animals(string tiengKeu, string cachDiChuyen, string mauLong)
			{
				TiengKeu = tiengKeu;
				CachDiChuyen = cachDiChuyen;
				MauLong = mauLong;
			}

			public abstract void Keu();
			public void An()
			{
				Console.WriteLine("An thit");
			}
		}
		class Cat : Animals
		{
			public string MonAnYeuThich { get; set; }
			public Cat(string monAnYeuThich) : base("Meo meo", "duoi mat dat", "mau xam")
			{
				MonAnYeuThich = monAnYeuThich;
			}

			public override void Keu()
			{
				Console.WriteLine("Meo meo");
			}
		}
		public interface IAnimal
		{
			 void Keu();
			 void DiChuyen();
		}
		class Bird : IAnimal
		{

			public void DiChuyen()
			{
				Console.WriteLine("bay len troi");
			}

			public void Keu()
			{
				Console.WriteLine("chip chip");
			}
		}
		internal class Program
		{
			static void Main(string[] args)
			{
				Animals a = new Cat("ca");
				a.Keu();
				a.An();
				Console.WriteLine("Hello, World!");
			}
		}
	}
}
