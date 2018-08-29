﻿using System;

// Статический класс в C#, выражает идею паттерна проектирования - Singleton.

// Правила:
// 1. Экземпляр статического класса нельзя создать.
// 2. Static class всегда наследуется от Оbject (Попытка наследования от чего либо другого приводит к ошибке компиляции).
// 3. Static class не реализует интерфейсы. Попытка наследования от интерфейса приводит к ошибке уровня компиляции. 
// 4. Содержит только статические члены (наличие в нем нестатического члена приведет к ошибке компиляции). 
// 5. Статический класс не может содержать конструкторов экземпляров.
// 6. Статический класс закрыт для наследования от него. Попытка наследования от статического класса приводит к ошибке уровня компиляции. 

namespace Static
{
    static class StaticClass : object  // Наследование только от Object (явно или неявно)
    {
        // Контруктор экземпляра - недопустим.
        // public StaticClass()
        // {
        //    Console.WriteLine("Constructor.");
        // }

        // Статический конструктор.
        static StaticClass()
        {
            Console.WriteLine("Static Constructor");
        }

        // Статический метод.
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        // Нестатический метод - недопустим.
        // public void NotStaticMethod()
        // {
        //    Console.WriteLine("NotStaticMethod");
        // }
    }
}
