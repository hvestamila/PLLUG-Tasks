using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class Parallelepiped
    {
        private double width;
        private double height;
        private double depth;
        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Depth
        {
            get { return depth; }
            set { depth = value; }
        }
    }

    class Sphere
    {
        private double diameter;
        public Sphere(double diameter)
        {
            this.Diameter = diameter;
        }
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
    }

    class Cylinder
    {
        private double diameter;
        private double height;
        public Cylinder(double diameter, double height)
        {
            this.Diameter = diameter;
            this.Height = height;
        }
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }

    class DoorRectang
    {
        private double width;
        private double height;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public DoorRectang(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
    class DoorCirc
    {
        private double diameter;
        public DoorCirc(double diameter)
        {
            this.Diameter = diameter;
        }
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
    }
}