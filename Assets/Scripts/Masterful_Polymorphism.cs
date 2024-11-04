using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShapeAreaCalculator : MonoBehaviour
{
    abstract class Shape
    {
        public abstract float CalculateArea();
    }

    class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public override float CalculateArea()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public float Radius { get; set; }
        public override float CalculateArea()
        {
            return Mathf.PI * Radius * Radius;
        }
    }

    class Triangle : Shape
    {
        public float Base { get; set; }
        public float Height { get; set; }
        public override float CalculateArea()
        {
            return 0.5f * Base * Height;
        }
    }

    class Square : Shape
    {
        public float Side { get; set; }
        public override float CalculateArea()
        {
            return Side * Side;
        }
    }

    class Dodecahedron : Shape
    {
        public float EdgeLength { get; set; }
        public override float CalculateArea()
        {
            return 3f * Mathf.Sqrt(25f + 10f * Mathf.Sqrt(5f)) * Mathf.Pow(EdgeLength, 2f);
        }
    }
    void Start()
    {
        // Array of shapes
        Shape[] shapes = {
            new Rectangle {Width = 5f, Height = 3f},
            new Circle {Radius = 4f},
            new Triangle {Base = 6f, Height = 2f},
            new Square {Side = 4f},
            new Dodecahedron {EdgeLength = 3f}
        };

        // Calculate and print areas of shapes
        foreach (var shape in shapes)
        {
            Debug.Log($"Area of {shape.GetType().Name}: {shape.CalculateArea()}");
        }
    }
}

