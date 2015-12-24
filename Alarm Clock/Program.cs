using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;             //Used to play song (SoundPlayer)
using System.Speech.Synthesis;  //Just for fun. Learning about this namespace

/*
Author: Julian D. Quitian
Date: 12/23/2015
*/

/// <summary>
/// Basic alarm clock
/// </summary>
namespace Alarm_Clock
{
    /// <summary>
    /// Alarm Clock object. Song is integrated separately, but could be included in AlarmClock class.
    /// </summary>
    class AlarmClock
    {
        public int day, month, year, hour, minute, second;
        private string dayString, monthString, yearString, hourString, minuteString, secondString;

        public void setDay(int day)
        {
            this.day = day;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public void setHour(int hour)
        {
            this.hour = hour;
        }

        public void setMinute(int minute)
        {
            this.minute = minute;
        }

        public void setSecond(int second)
        {
            this.second = second;
        }

        public void inputDay()
        {
            Console.Write("Day: ");
            dayString = Console.ReadLine();
            while (int.TryParse(dayString, out this.day) == false)
            {
                Console.Write("\nPlease enter a valid day: ");
                dayString = Console.ReadLine();
            }
            this.day = int.Parse(dayString);
        }

        public void inputMonth()
        {
            Console.Write("Month: ");
            monthString = Console.ReadLine();
            while (int.TryParse(monthString, out this.month) == false)
            {
                Console.Write("\nPlease enter a valid month: ");
                monthString = Console.ReadLine();
            }
            this.month = int.Parse(monthString);
        }

        public void inputYear()
        {
            Console.Write("Year: ");
            yearString = Console.ReadLine();
            while (int.TryParse(yearString, out this.year) == false)
            {
                Console.Write("\nPlease enter a valid year: ");
                yearString = Console.ReadLine();
            }
            this.year = int.Parse(yearString);
        }

        public void inputHour()
        {
            Console.Write("Hour (Military Time): ");
            hourString = Console.ReadLine();
            while (int.TryParse(hourString, out this.hour) == false)
            {
                Console.Write("\nPlease enter a valid hour: ");
                hourString = Console.ReadLine();
            }
            this.hour = int.Parse(hourString);
        }

        public void inputMinute()
        {
            Console.Write("Minute: ");
            minuteString = Console.ReadLine();
            while (int.TryParse(minuteString, out this.minute) == false)
            {
                Console.Write("\nPlease enter a valid minute: ");
                minuteString = Console.ReadLine();
            }
            this.minute = int.Parse(minuteString);
        }

        public void inputSecond()
        {
            Console.Write("Second: ");
            secondString = Console.ReadLine();
            while (int.TryParse(secondString, out this.second) == false)
            {
                Console.Write("\nPlease enter a valid second: ");
                secondString = Console.ReadLine();
            }
            this.second = int.Parse(secondString);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer cyby = new SpeechSynthesizer();   //Used to make Cyby speak
            SoundPlayer player = new SoundPlayer(@"C:\Users\Julian D. Quitian\Downloads\a.wav");    //Used to play song. Replace with .wav file to play your song.
            AlarmClock alarm1 = new AlarmClock();   //Declaring and Initializing alarm1
            DateTime now;   //Declaring DateTime object.

            cyby.Speak("Hello! I am Cybertron, your personal alarm clock. When would you like to wake up?");

            alarm1.inputMonth();
            alarm1.inputDay();
            alarm1.inputYear();
            alarm1.inputHour();
            alarm1.inputMinute();
            alarm1.inputSecond();

            //Loop never ends. Close program to turn off alarm.
            while (1 == 1)
            {
                now = DateTime.Now;
                if (now.Month == alarm1.month)
                    if (now.Day == alarm1.day)
                        if (now.Year == alarm1.year)
                            if (now.Hour == alarm1.hour)
                                if (now.Minute == alarm1.minute)
                                    if (now.Second == alarm1.second)
                                    {
                                        cyby.Speak("Rise and shine! The sun is shining, the birds are chirping. Wake up immediately!");
                                        System.Threading.Thread.Sleep(5 * 1000);
                                        cyby.Speak("Fine! Let's do this the hard way!");
                                        player.PlayLooping();
                                    }

            }
        }
    }
}
