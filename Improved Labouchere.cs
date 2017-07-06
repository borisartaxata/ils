using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{

			int balance = 100000;
			int balance1 = balance;

			//sssss

			ArrayList D = new ArrayList();
			int x = 1;

			D.Add(x); //int türünde değer ekleme
			D.Add(x); //int türünde değer ekleme

			int n = 1; // Dizi Eleman Sayısı, 2 olması gerekiyordu 0 ile başladığı için 1 oldu

			int bet_type = 0; // Kırmızı mod6ya göre 0

			int eleman_sayisi = D.Count;

			int maxbetlimit = 100;
			int maxbet = 0;
			int spin = 1000;
			int win = 0;
			int lose = 0;
			int bet_size = (int)D[0] + (int)D[n];

			Console.WriteLine(bet_size);

			for (int i = 0; i < spin+1; i++)
			{

				Random rastgele = new Random();
				int sayi = rastgele.Next(37);
				System.Threading.Thread.Sleep(10);

				Console.Write(sayi + "     ");

				if (bet_type % 6 == 0)
				{

					if (sayi == 1 || sayi == 3 || sayi == 5 || sayi == 7 || sayi == 9 || sayi == 12 || sayi == 14 || sayi == 16 || sayi == 18 || sayi == 19 || sayi == 21 || sayi == 23 || sayi == 25 || sayi == 27 || sayi == 30 || sayi == 32 || sayi == 34 || sayi == 36)
					{
						Console.Write("WIN     ");
						win = win + 1;
						balance = balance + bet_size;
						Console.Write(balance + "      ");
						n = n - 2;
						Console.Write(n + "     ");


						if (n == -1)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;

						}
						// bunun sonucu ÜSTe gidiyor

						else if (n == -2)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
						}


						else if (n == 0)
						{
							D.RemoveAt(2);
							D.RemoveAt(0);
							bet_size = (int)D[0];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);
							Console.WriteLine(D[0]);
						}

						else
						{


							D.RemoveAt(n + 2);
							D.RemoveAt(0);
							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");
						}


					}
					else
					{
						Console.Write("LOSE     ");
						lose = lose + 1;
						balance = balance - bet_size;
						Console.Write(balance);

						if (n == 0)
							D.Add((int)D[0]);
						else
							D.Add((int)D[0] + (int)D[n]);

						n = n + 1;
						Console.Write("     " + n);
						bet_size = (int)D[0] + (int)D[n];
						if (bet_size > maxbet)
							maxbet = bet_size;
						Console.WriteLine("     " + bet_size);

						for (int j = 0; j <= n; j++)

						{
							Console.Write(D[j] + " ");
						}

						if (bet_size > maxbetlimit)
						{
							bet_type = bet_type + 1;
							D.Clear();
							D.Add(x);
							D.Add(x);
							n = 1;
						}

						Console.WriteLine(" ");
					}

				}

				else if (bet_type % 6 == 1)
				{

					if (sayi > 18)
					{
						Console.Write("WIN     ");
						win = win + 1;
						balance = balance + bet_size;
						Console.Write(balance + "      ");
						n = n - 2;
						Console.Write(n + "     ");


						if (n == -1)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;

						}
						// bunun sonucu ÜSTe gidiyor

						else if (n == -2)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
						}


						else if (n == 0)
						{
							D.RemoveAt(2);
							D.RemoveAt(0);
							bet_size = (int)D[0];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);
							Console.WriteLine(D[0]);
						}

						else
						{


							D.RemoveAt(n + 2);
							D.RemoveAt(0);
							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");
						}


					}
					else
					{
						Console.Write("LOSE     ");
						lose = lose + 1;
						balance = balance - bet_size;
						Console.Write(balance);

						if (n == 0)
							D.Add((int)D[0]);
						else
							D.Add((int)D[0] + (int)D[n]);

						n = n + 1;
						Console.Write("     " + n);
						bet_size = (int)D[0] + (int)D[n];
						if (bet_size > maxbet)
							maxbet = bet_size;
						Console.WriteLine("     " + bet_size);

						for (int j = 0; j <= n; j++)

						{
							Console.Write(D[j] + " ");
						}

						if (bet_size > maxbetlimit)
						{
							bet_type = bet_type + 1;
							D.Clear();
							D.Add(x);
							D.Add(x);
							n = 1;
						}

						Console.WriteLine(" ");
					}

				}
				else if (bet_type % 6 == 2)
				{
					if (sayi % 2 == 1)
					{
						Console.Write("WIN     ");
						win = win + 1;
						balance = balance + bet_size;
						Console.Write(balance + "      ");
						n = n - 2;
						Console.Write(n + "     ");


						if (n == -1)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;

						}
						// bunun sonucu ÜSTe gidiyor

						else if (n == -2)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
						}


						else if (n == 0)
						{
							D.RemoveAt(2);
							D.RemoveAt(0);
							bet_size = (int)D[0];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);
							Console.WriteLine(D[0]);
						}

						else
						{


							D.RemoveAt(n + 2);
							D.RemoveAt(0);
							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");
						}


					}
					else
					{
						Console.Write("LOSE     ");
						lose = lose + 1;
						balance = balance - bet_size;
						Console.Write(balance);

						if (n == 0)
							D.Add((int)D[0]);
						else
							D.Add((int)D[0] + (int)D[n]);

						n = n + 1;
						Console.Write("     " + n);
						bet_size = (int)D[0] + (int)D[n];
						if (bet_size > maxbet)
							maxbet = bet_size;
						Console.WriteLine("     " + bet_size);

						for (int j = 0; j <= n; j++)

						{
							Console.Write(D[j] + " ");
						}

						if (bet_size > maxbetlimit)
						{
							bet_type = bet_type + 1;
							D.Clear();
							D.Add(x);
							D.Add(x);
							n = 1;
						}

						Console.WriteLine(" ");
					}
				}
				else if (bet_type % 6 == 3)
				{
					if (sayi == 2 || sayi == 4 || sayi == 6 || sayi == 8 || sayi == 10 || sayi == 11 || sayi == 13 || sayi == 15 || sayi == 17 || sayi == 20 || sayi == 22 || sayi == 24 || sayi == 26 || sayi == 28 || sayi == 29 || sayi == 31 || sayi == 33 || sayi == 35)
					{
						Console.Write("WIN     ");
						win = win + 1;
						balance = balance + bet_size;
						Console.Write(balance + "      ");
						n = n - 2;
						Console.Write(n + "     ");


						if (n == -1)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;

						}
						// bunun sonucu ÜSTe gidiyor

						else if (n == -2)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
						}


						else if (n == 0)
						{
							D.RemoveAt(2);
							D.RemoveAt(0);
							bet_size = (int)D[0];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);
							Console.WriteLine(D[0]);
						}

						else
						{


							D.RemoveAt(n + 2);
							D.RemoveAt(0);
							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");
						}


					}
					else
					{
						Console.Write("LOSE     ");
						lose = lose + 1;
						balance = balance - bet_size;
						Console.Write(balance);

						if (n == 0)
							D.Add((int)D[0]);
						else
							D.Add((int)D[0] + (int)D[n]);

						n = n + 1;
						Console.Write("     " + n);
						bet_size = (int)D[0] + (int)D[n];
						if (bet_size > maxbet)
							maxbet = bet_size;
						Console.WriteLine("     " + bet_size);

						for (int j = 0; j <= n; j++)

						{
							Console.Write(D[j] + " ");
						}

						if (bet_size > maxbetlimit)
						{
							bet_type = bet_type + 1;
							D.Clear();
							D.Add(x);
							D.Add(x);
							n = 1;
						}

						Console.WriteLine(" ");
					}
				}
				else if (bet_type % 6 == 4)
				{
					if (sayi < 19)

					{
						Console.Write("WIN     ");
						win = win + 1;
						balance = balance + bet_size;
						Console.Write(balance + "      ");
						n = n - 2;
						Console.Write(n + "     ");


						if (n == -1)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;

						}
						// bunun sonucu ÜSTe gidiyor

						else if (n == -2)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
						}


						else if (n == 0)
						{
							D.RemoveAt(2);
							D.RemoveAt(0);
							bet_size = (int)D[0];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);
							Console.WriteLine(D[0]);
						}

						else
						{


							D.RemoveAt(n + 2);
							D.RemoveAt(0);
							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");
						}


					}
					else
					{
						Console.Write("LOSE     ");
						lose = lose + 1;
						balance = balance - bet_size;
						Console.Write(balance);

						if (n == 0)
							D.Add((int)D[0]);
						else
							D.Add((int)D[0] + (int)D[n]);

						n = n + 1;
						Console.Write("     " + n);
						bet_size = (int)D[0] + (int)D[n];
						if (bet_size > maxbet)
							maxbet = bet_size;
						Console.WriteLine("     " + bet_size);

						for (int j = 0; j <= n; j++)

						{
							Console.Write(D[j] + " ");
						}

						if (bet_size > maxbetlimit)
						{
							bet_type = bet_type + 1;
							D.Clear();
							D.Add(x);
							D.Add(x);
							n = 1;
						}

						Console.WriteLine(" ");
					}


				}
				else if (bet_type % 6 == 5)
				{
					if ( sayi % 2 == 0)
						{
						Console.Write("WIN     ");
						win = win + 1;
						balance = balance + bet_size;
						Console.Write(balance + "      ");
						n = n - 2;
						Console.Write(n + "     ");


						if (n == -1)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;

						}
						// bunun sonucu ÜSTe gidiyor

						else if (n == -2)
						{
							bet_type = bet_type + 1;
							D.Clear();
							Console.WriteLine("Dizi bitti");

							D.Add(x);
							D.Add(x);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");

							n = 1;

							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
						}


						else if (n == 0)
						{
							D.RemoveAt(2);
							D.RemoveAt(0);
							bet_size = (int)D[0];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);
							Console.WriteLine(D[0]);
						}

						else
						{


							D.RemoveAt(n + 2);
							D.RemoveAt(0);
							bet_size = (int)D[0] + (int)D[n];
							if (bet_size > maxbet)
								maxbet = bet_size;
							Console.WriteLine("     " + bet_size);

							for (int j = 0; j <= n; j++)

							{
								Console.Write(D[j] + " ");
							}
							Console.WriteLine(" ");
						}


					}
					else
					{
						Console.Write("LOSE     ");
						lose = lose + 1;
						balance = balance - bet_size;
						Console.Write(balance);

						if (n == 0)
							D.Add((int)D[0]);
						else
							D.Add((int)D[0] + (int)D[n]);

						n = n + 1;
						Console.Write("     " + n);
						bet_size = (int)D[0] + (int)D[n];
						if (bet_size > maxbet)
							maxbet = bet_size;
						Console.WriteLine("     " + bet_size);

						for (int j = 0; j <= n; j++)

						{
							Console.Write(D[j] + " ");
						}

						if (bet_size > maxbetlimit)
						{
							bet_type = bet_type + 1;
							D.Clear();
							D.Add(x);
							D.Add(x);
							n = 1;
						}

						Console.WriteLine(" ");
					}
				}
				else
					Console.WriteLine("1");
			}

			Console.WriteLine("***************************");
			Console.WriteLine();
			Console.WriteLine("Starting Balance: " + balance1);
			Console.WriteLine();
			int profit = balance - balance1;
			Console.WriteLine("Profit = " + profit);
			int time = (spin / 60);
			Console.WriteLine("Geçirilen Süre = " + time + " saat");
			Console.WriteLine();
			Console.WriteLine("Maximum Bet per hand = " + maxbet);
			Console.WriteLine();
			Console.WriteLine("Win Count = " + win);
			Console.WriteLine();
			Console.WriteLine("Lose Count = " + lose);
			Console.WriteLine();
			Console.WriteLine("***************************");
			Console.ReadLine();

		}
	}
}
