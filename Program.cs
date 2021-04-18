using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_4
{
    public class Object2D
    {
        public int x, y; // поля-координати
        // конструктор
        public Object2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        // метод для "відлображення"
        public virtual void Draw()
        {
            Console.WriteLine(
                "Об'єкт з координатами {0},{1}",
                x, y
                );
        }
        // метод "переміщенння"
        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
            Draw();
        }
    }
    // клас точка
    public class Point : Object2D
    {
        public Point(int x, int y) : base(x, y)
        // конструктор Point
        // на батьківський
        // конструктор - Object2D 
        {

        }
        public override void Draw()
        {
            //повністю перекриває
            //батьківський метод
            Console.WriteLine
                ("точка з координатами {0},{1}",
                x, y
                );
        }
    }
    // клас коло 
    public class Circle : Object2D
    {
        public int r; // нове полн - радіус
        public Circle(int x, int y, int r) : base(x, y)
        {
            this.r = r;
        }
        public override void Draw()
        {
            //спочатку викликає батьківський метод
            base.Draw();
            //потім доповнює його
            Console.WriteLine("це коло радiусом {0}", r);

        }
    }
    class Test_71
    {
        static void Main()
        {
            Point p0 = new Point(10, 20);
            Point p1 = new Point(1, 40);
            Circle c0 = new Circle(15, 17, 10);
            //створення масиву вказiвникiв
            //на об'єкти Object2D
            Object2D[] objects = new Object2D[3];
            // спочатку всі елементи цього масиву рівні null
            //заповнимо його поисланням на
            //створенi об'єкти
            objects[0] = p0;
            objects[1] = p1;
            objects[2] = c0;
            //тепер над ними можна виконувати груповi дiї
            //вiдображення
            foreach (Object2D o in objects)
            {
                o.Draw();
            }
            Console.WriteLine("\n\rпiсля змiщення\n\r");
            //зміщення
            foreach (Object2D o in objects)
            {
                o.Move(5, -4);
            }
            Console.ReadKey();
        }

    }


}

      
