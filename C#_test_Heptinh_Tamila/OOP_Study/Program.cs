using System;
using System.Text;

namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Press 1 if the door is rectangular" +
                    "\nPress 2 if the door is circular");
                int DoorType = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Press 1 if the shape is a parallelepiped" +
                    "\nPress 2 if the shape is a cylinder" +
                    "\nPress 3 if the shape is a sphere");
                int ShapeType = Convert.ToInt16(Console.ReadLine());

                double dw;
                double dh;
                DoorRectang DoorRect; 
                double diam;
                DoorCirc DoorCirc;
                double w;
                double h;
                double d;
                Parallelepiped Parallelepiped;
                double diamShapeCylinder;
                double heightShapeCylinder;
                Cylinder Cylinder;
                double diamSphere;
                Sphere Sphere;

                if (DoorType == 1)  //якщо двері прямокутні
                {
                    Console.WriteLine("Enter the width of the door ");
                    dw = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height of the door ");
                    dh = Convert.ToDouble(Console.ReadLine());
                    DoorRect = new DoorRectang(dw, dh);
                    if (ShapeType == 1) //якщо обєкт паралелепіпед
                    {
                        Console.WriteLine("Enter the width of the Parallelepiped ");
                        w = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the height of the Parallelepiped ");
                        h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the depth of the Parallelepiped ");
                        d = Convert.ToDouble(Console.ReadLine());
                        Parallelepiped = new Parallelepiped(w, h, d);
                        if ((DoorRect.Height > Parallelepiped.Height && DoorRect.Width > Parallelepiped.Width) ||
                            (DoorRect.Height > Parallelepiped.Height && DoorRect.Width > Parallelepiped.Depth) ||
                            (DoorRect.Height > Parallelepiped.Width && DoorRect.Width > Parallelepiped.Depth) ||
                            (DoorRect.Width > Parallelepiped.Height && DoorRect.Height > Parallelepiped.Width) ||
                            (DoorRect.Width > Parallelepiped.Height && DoorRect.Height > Parallelepiped.Depth) ||
                            (DoorRect.Width > Parallelepiped.Width && DoorRect.Height > Parallelepiped.Depth))
                        {
                            Console.WriteLine("You can fit the Parallelepiped through the door.");
                        }
                        else
                        {
                            Console.WriteLine("You can't fit the Parallelepiped through the door.");
                        }
                    }
                    else if (ShapeType == 2) //якщо обєкт циліндр
                    {
                        Console.WriteLine("Enter the diameter of the cylinder ");
                        diamShapeCylinder = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the height of the cylinder ");
                        heightShapeCylinder = Convert.ToDouble(Console.ReadLine());
                        Cylinder = new Cylinder(diamShapeCylinder, heightShapeCylinder);
                        if ((DoorRect.Height > Cylinder.Height && DoorRect.Width > Cylinder.Diameter) ||
                            (DoorRect.Width > Cylinder.Diameter && DoorRect.Height > Cylinder.Diameter) ||
                            (DoorRect.Width > Cylinder.Height && DoorRect.Height > Cylinder.Diameter))
                        {
                            Console.WriteLine("You can fit the cylinder through the door.");
                        }
                        else
                        {
                            Console.WriteLine("You can't fit the cylinder through the door.");
                        }
                    }
                    else //якщо обєкт куля
                    {
                        Console.WriteLine("Enter the diameter of the sphere ");
                        diamSphere = Convert.ToDouble(Console.ReadLine());
                        Sphere = new Sphere(diamSphere);
                        if (DoorRect.Width > Sphere.Diameter && DoorRect.Height > Sphere.Diameter)
                        {
                            Console.WriteLine("You can fit the sphere through the door.");
                        }
                        else
                        {
                            Console.WriteLine("You can't fit the sphere through the door.");
                        }
                    }
                }
                else //якщо двері круглі
                {
                    Console.WriteLine("Enter the diameter of the door ");
                    diam = Convert.ToDouble(Console.ReadLine());
                    DoorCirc = new DoorCirc(diam);
                    if (ShapeType == 1) //якщо обєкт паралелепіпед
                    {
                        Console.WriteLine("Enter the width of the Parallelepiped ");
                        w = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the height of the Parallelepiped ");
                        h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the depth of the Parallelepiped ");
                        d = Convert.ToDouble(Console.ReadLine());
                        Parallelepiped = new Parallelepiped(w, h, d);
                        double hypotenuseFront = Math.Sqrt(Math.Pow(Parallelepiped.Width, 2) + Math.Pow(Parallelepiped.Height, 2));
                        double hypotenuseSide = Math.Sqrt(Math.Pow(Parallelepiped.Depth, 2) + Math.Pow(Parallelepiped.Height, 2));
                        double hypotenuseTop = Math.Sqrt(Math.Pow(Parallelepiped.Width, 2) + Math.Pow(Parallelepiped.Depth, 2));
                        if ((DoorCirc.Diameter > hypotenuseFront) ||
                            (DoorCirc.Diameter > hypotenuseSide) ||
                            (DoorCirc.Diameter > hypotenuseTop))
                        {
                            Console.WriteLine("You can fit the parallelepiped through the door.");
                        }
                        else
                        {
                            Console.WriteLine("You can't fit the Parallelepiped through the door.");
                        }
                    }
                    else if (ShapeType == 2) //якщо обєкт циліндр
                    {
                        Console.WriteLine("Enter the diameter of the cylinder ");
                        diamShapeCylinder = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the height of the cylinder ");
                        heightShapeCylinder = Convert.ToDouble(Console.ReadLine());
                        Cylinder = new Cylinder(diamShapeCylinder, heightShapeCylinder);
                        if (DoorCirc.Diameter > Cylinder.Diameter)
                        {
                            Console.WriteLine("You can fit the cylinder through the door.");
                        }
                        else
                        {
                            Console.WriteLine("You can't fit the cylinder through the door.");
                        }
                    }
                    else //якщо обєкт куля
                    {
                        Console.WriteLine("Enter the diameter of the sphere ");
                        diamSphere = Convert.ToDouble(Console.ReadLine());
                        Sphere = new Sphere(diamSphere);
                        if (DoorCirc.Diameter > Sphere.Diameter)
                        {
                            Console.WriteLine("You can fit the sphere through the door.");
                        }
                        else
                        {
                            Console.WriteLine("You can't fit the sphere through the door.");
                        }
                    }
                }
            }  
        }
    }
}
   

   
    

    

