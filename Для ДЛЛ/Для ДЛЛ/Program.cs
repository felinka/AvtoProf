using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Для_ДЛЛ
{
	class Program
	{

		static string[] AvailablePeriods(TimeSpan[] startTimes, int[]durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
		{
			for (int i = 1; i <= startTimes.Length - 1; i++)
			{
				for (int j = 0; j <= startTimes.Length - 2; j++)
				{
					if (startTimes[j] > startTimes[i])
					{
						TimeSpan tmp = startTimes[i];
						int temp = durations[i];
						startTimes[i] = startTimes[j];
						durations[i] = durations[j];
						startTimes[j] = tmp;
						durations[j] = temp;
					}
				}
			}



			List<string> LstFreeTime = new List<string>();

			List<DateTime> LstBeginTime = new List<DateTime>();
			LstBeginTime.Add(DateTime.Parse(beginWorkingTime.ToString()));

			foreach (TimeSpan item in startTimes)
			{
				LstBeginTime.Add(DateTime.Parse(item.ToString()));
			}

			LstBeginTime.Add(DateTime.Parse(endWorkingTime.ToString()));

			List<int> Lenght = new List<int>();
			Lenght.Add(0);
			Lenght.AddRange(durations);

			DateTime CurrentTime;

			for (int i = 0; i <= LstBeginTime.Count - 2; i++)
			{
				CurrentTime = LstBeginTime[i].AddMinutes(Lenght[i]);
				while (CurrentTime.AddMinutes(consultationTime) <= LstBeginTime[i + 1])
				{
					LstFreeTime.Add(CurrentTime.ToString("HH:mm") + "-" + CurrentTime.AddMinutes(consultationTime).ToString("HH:mm"));
					CurrentTime = CurrentTime.AddMinutes(consultationTime);
				}
			}



			

			foreach (var s in LstFreeTime)
			{
				Console.WriteLine(s);
			}


			return LstFreeTime.ToArray();

		}

		static void Main(string[] args)
		{
			TimeSpan[] startTime = { TimeSpan.Parse("16:30"), TimeSpan.Parse("12:30"), TimeSpan.Parse("14:00"), TimeSpan.Parse("15:00"), TimeSpan.Parse("10:00") };
			int[] durations = { 10, 20, 30, 40, 30 };

			TimeSpan beginWorkingTime = TimeSpan.Parse("08:00");
			TimeSpan endWorkingTime = TimeSpan.Parse("17:00");

			//TimeSpan[] startTime = { };
			//int[] durations = {  };

			//TimeSpan[] startTime = { TimeSpan.Parse("08:00"), TimeSpan.Parse("12:30"), TimeSpan.Parse("14:00"), TimeSpan.Parse("15:00"), TimeSpan.Parse("16:30") };
			//int[] durations = { 30, 20, 30, 40, 30 };

			//TimeSpan[] startTime = { TimeSpan.Parse("08:00"), TimeSpan.Parse("09:00"), TimeSpan.Parse("09:50") };
			//int[] durations = { 35, 30, 20 };

			//TimeSpan[] startTime = { TimeSpan.Parse("08:00"), TimeSpan.Parse("08:30"), TimeSpan.Parse("09:00"), TimeSpan.Parse("09:50") };
			//int[] durations = { 30, 30, 30, 20 };

			//TimeSpan beginWorkingTime = TimeSpan.Parse("08:00");
			//TimeSpan endWorkingTime = TimeSpan.Parse("10:00");

			//TimeSpan[] startTime = { };
			//int[] durations = { };

			//TimeSpan beginWorkingTime = TimeSpan.Parse("08:00");
			//TimeSpan endWorkingTime = TimeSpan.Parse("08:25");

			//TimeSpan[] startTime = { TimeSpan.Parse("08:00") };
			//int[] durations = { 0 };

			//TimeSpan beginWorkingTime = TimeSpan.Parse("08:00");
			//TimeSpan endWorkingTime = TimeSpan.Parse("08:30");

			AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, 30);


			Console.ReadKey();
		}
	}
}
