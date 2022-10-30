using Lab1;
using lab7;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllLabs.Lab5
{
    class Lab7 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы

            Group PKS20 = new Group();
            PKS20.Add(new Students("Темраз", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
            PKS20.Add(new Students("Геннадий", 19, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
            PKS20.Add(new Students("Андрей", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
            PKS20.Add(new Students("Владислав", 17, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));

            Group BD = new Group();
            BD.Add(new Students("Мария", 19, "женский", "BD", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Students("Сергей", 21, "мужской", "BD", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Students("Григорий", 20, "мужской", "BD", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Students("Ангелина", 20, "женский", "BD", "ВКУиНТ", "Банковское дело"));
            Group GD = new Group();

            GD.Add(new Students("Анжела", 20, "женский", "GD", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Students("Валерий", 20, "мужской", "GD", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Students("Евгений", 22, "мужской", "GD", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Students("Василий", 19, "мужской", "GD", "ВКУиНТ", "Гостиничное дело"));



            List<Group> GroupList = new List<Group>();
            GroupList.Add(PKS20);
            GroupList.Add(GD);
            GroupList.Add(BD);
            Console.WriteLine("Группа: ПКС-20");
            PKS20.PrintGroup();
            Console.WriteLine("Группа: ГД-18");
            GD.PrintGroup();
            Console.WriteLine("Группа: БД-19");
            BD.PrintGroup();

            Console.WriteLine();
            Console.ReadKey();

        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задание 7";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 7;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №7. Сериализация";
        }
    }
}