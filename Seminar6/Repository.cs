﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Seminar6
{
    internal class Repository
    {
        private static String file = @"G:\VisualStudioHomework\Seminar6\test.txt";
        private static String new_file = @"G:\VisualStudioHomework\Seminar6\test2.txt";
        public String time_file = @"G:\VisualStudioHomework\Seminar6\time.txt";

        private static Worker worker;

        public Worker GetAllWorkers(int id)
        {
            String text = GetLine(id);
            string[] array = text.Split("#");
            worker.id = int.Parse(array[0]);
            worker.dateString = array[1];
            worker.fullName = array[2];
            worker.age = int.Parse(array[3]);
            worker.height = int.Parse(array[4]);
            worker.birthdayString = array[5];
            worker.city = array[6];
            return worker;
        }

        public Worker GetWorkerById(int id)
        {
            if (id == 1)
            {
                return GetAllWorkers(id-1);
            }
            else
            {
                String text = GetLineById(id);
                string[] array = text.Split("#");
                worker.id = id;
                worker.dateString = array[1];
                worker.fullName = array[2];
                worker.age = int.Parse(array[3]);
                worker.height = int.Parse(array[4]);
                worker.birthdayString = array[5];
                worker.city = array[6];
                return worker;
            }
        }

        public void DeleteWorker(int id)
        {
            string empty_line = null;
            int i = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                using (StreamWriter writer = new StreamWriter(new_file))
                {
                    while ((empty_line = reader.ReadLine()) != null)
                    {
                        i++;
                        string text = GetLine(i-1);
                        string[] array = text.Split("#");
                        
                        if (int.Parse(array[0]) == id)
                            continue;
                        

                        writer.WriteLine(empty_line);
                    }
                }
            }
            File.Delete(file);
            File.Move(new_file, file);
        }

        public void AddWorker(Worker worker)
        {
            string[] array = new string[] { worker.id.ToString(), worker.dateString, worker.fullName, worker.age.ToString(), worker.height.ToString(), worker.birthdayString, worker.city };
            String text = String.Join("#", array);
            TextWriter tw = new StreamWriter(file, true);
            tw.WriteLine(text);
            tw.Close();
        }

        public void GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            string line = GetLine(1);
            string empty_line = null;
            int i = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                using (StreamWriter writer = new StreamWriter(time_file))
                {
                    while ((empty_line = reader.ReadLine()) != null)
                    {
                        line = GetLine(i);
                        string[] array = line.Split("#");
                        if (DateTime.Parse(array[1]) < dateFrom || DateTime.Parse(array[1]) > dateTo)
                        {
                            continue;
                        }
                        writer.WriteLine(line);
                        i++;
                    }
                }
            }
        }

        private String GetLineById(int id)
        {
            int i = 1;
            int check_id = 1;
            string line = GetLine(i);
            string empty_line = null;
            using (StreamReader reader = new StreamReader(file))
            {
                while ((empty_line = reader.ReadLine()) != null)
                {
                    line = GetLine(i);
                    string[] past_id = line.Split("#");
                    check_id = int.Parse(past_id[0]);
                    if (check_id == id)
                    {
                        break;
                    }
                    i++;
                }
                return GetLine(i);
            }
        }

        public String GetLine(int id)
        {
            using (var sr = new StreamReader(file))
            {
                for (int i = 1; i <= id; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
    }
}
