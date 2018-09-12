using System;
using System.Text;

namespace Lab02
{
	class Program
	{
		static void Main(string[] args)
		{
			//-------1--------//
			//a
			sbyte sbVar = 14;
			short sVar = 27;
			int iVar = 42;
			long lVar = 322;
			byte bVar = 44;
			ushort usVar = 54;
			uint uiVar = 1969;
			ulong ulVar = 2_678_332;
			char cVar = 'f';
			bool boolVar = true;
			float fVar = 3.14F;
			double dVar = 6.77732;
			decimal decVar = 244_532_664_224;
			//b 1)Неявные приведения
			sVar = sbVar;
			lVar = iVar;
			usVar = bVar;
			ulVar = uiVar;
			dVar = fVar;
			// 2) Явные приведения
			iVar = (int)cVar;  // избыточно
			cVar = (char)bVar; // неизбыточно
			decVar = (decimal)fVar;
			uiVar = (uint)ulVar;
			dVar = (double)fVar;
			//c 
			Object obj;
			obj = boolVar;       // упаковка
			boolVar = (bool)obj; // распаковка
								 //d
			var impTyped = 42; // тип выподится из присваемого значения в д.с. int
							   //e
			int? mbNull = null;     // может хранить как значения, так и null
			impTyped = mbNull ?? 5; // присвоение хранимого значения при наличии. Иначе присвоение второго операнда в д.с. 5

			//-------2--------//
			//a
			String str1 = "Hello there!", str2 = "hello there!";
			if (str1.CompareTo(str2) == 0)
			{
				Console.WriteLine("Строка \"{0}\" идентична строке \"{1}\"", str1, str2);
			}
			else
			{
				Console.WriteLine("Строка \"{0}\" не идентична строке \"{1}\"", str1, str2);
			}
			//b
			String str3 = "don't", str4 = "worry", str5 = "be happy";
			String resConcat = str3 + " " + str4 + ". " + str5;
			Console.WriteLine(resConcat);
			String beHappyCopy = String.Copy(str5);
			String happySub = beHappyCopy.Substring(3);
			Console.WriteLine(happySub);
			String[] words = resConcat.Split(' ');
			foreach (String s in words)
			{
				Console.WriteLine(s);
			}
			String falseParadigm = resConcat.Insert(resConcat.Length, " without programming");
			Console.WriteLine(falseParadigm);
			String rightParadigm = falseParadigm.Remove(26, 3);
			Console.WriteLine(rightParadigm);
			//c
			String emptyStr = "", nullStr = null;
			if (emptyStr.CompareTo(nullStr) == 0) // для пустой строки можно вызывать методы,будут идентичны
			{
				Console.WriteLine("Строка \"{0}\" идентична строке \"{1}\"", emptyStr, nullStr);
			}
			else
			{
				Console.WriteLine("Строка \"{0}\" идентична строке \"{1}\"", emptyStr, nullStr);
			}
			try
			{
				if (nullStr.CompareTo(emptyStr) == 0) // для null-строки нельзя вызывать методы, будет вызвано исключение
				{
					Console.WriteLine("Строка \"{0}\" идентична строке \"{1}\"", emptyStr, nullStr);
				}
				else
				{
					Console.WriteLine("Строка \"{0}\" идентична строке \"{1}\"", emptyStr, nullStr);
				}
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine("Вызвано исключение: " + e.Message);
			}
			//d
			StringBuilder strB = new StringBuilder("Original text", 42);
			strB.Remove(0, 9);
			Console.WriteLine(strB);
			strB.Insert(0, "Not original ");
			strB.Append(".Just some additional text.");
			Console.WriteLine(strB);
			//-------3--------//
			//a
			int[,] arr2D = new int[,] { { 5, 4, 3 }, { 2, 4, 5 }, { 5, 2, 3 } };
			for (int i = 0; i < arr2D.GetLength(0); i++)
			{
				for (int j = 0; j < arr2D.GetLength(1); j++)
				{
					Console.Write("{0} ", arr2D[i, j]);
				}
				Console.WriteLine();
			}
			//b
			String[] strArr = new string[4] { "east", "is", "up", "!!!" };
			foreach (String s in strArr)
			{
				Console.Write("{0} ", s);
			}
			Console.WriteLine("Длина массива строк:{0}", strArr.Length);
			strArr[3] = "???";
			//c
			float[][] jaggedArr = { new float[2], new float[3], new float[4] };
			Console.WriteLine("Введите элементы массива:");
			try
			{
				for (int i = 0; i < jaggedArr.GetLength(0); i++)
				{
					Console.WriteLine("Введите {0} элемента(ов) в {1} массив:", jaggedArr[i].Length, i + 1);
					String enterString = Console.ReadLine();
					string[] arrString = enterString.Split(new Char[] { ' ' });
					for (int j = 0; j < jaggedArr[i].Length; j++)
					{
						jaggedArr[i][j] = float.Parse(arrString[j]);
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Вызвано исключение: " + e.Message);
			}
			//d
			var arr = new int[24];
			var str = "";
			//-------4--------//
			//a
			(int intMem, String strMem1, char charMem, String strMem2, ulong ulMem) tuple1 = (42, "String", 'c',"One more string",352);
			//c
			Console.WriteLine("{0} {1} {2}",tuple1.intMem.ToString(),tuple1.charMem,tuple1.strMem2);
			Console.WriteLine(tuple1);
			//d
			(var one, var two, var three, var fourth, var fifth) = tuple1;
			Console.WriteLine(one);
			//e
			(int intMem, String strMem1, char charMem, String strMem2, ulong ulMem) tuple2 = (42, "String", 'c', "One more string", 352);
			if (tuple1.CompareTo(tuple2) == 0)
			{
				Console.WriteLine("Картеж {0} идентичен картежу {1}", tuple1, tuple2);
			}
			else
			{
				Console.WriteLine("Картеж {0} не идентичен картежу {1}", tuple1, tuple2);
			}
			//-------5--------//
			(int max, int min, int sum,char firstLet) LocFun(int[] array,String strLoc)
			{
				int sum=0;
				foreach(int i in array)
				{
					sum += i;
				}
				Array.Sort(array);
				return (array[array.Length - 1], array[0], sum, strLoc.ToCharArray()[0]);
			}
			int[] intArr = { 4, 5, 6, 2, 1, 5 };
			Console.WriteLine(LocFun(intArr, str1));
		}
	}
}
