using System;

namespace Ex_ShapesVolume
{
    public static class VolumeCalculator
    {
        static TriangularPrism tP = new TriangularPrism();
        static Cube c = new Cube();
        static Cylinder cy = new Cylinder();

        public static double VolumeTP()
        {
            return tP.BaseSide * tP.Length / 2 * tP.Height;
        }

        public static double VolumeCube()
        {
            return Math.Pow(c.SideLength, 3); //Equivalente a (c.SideLenght ^ 3)
        }

        public static double VolumeCylinder()
        {
            return Math.PI * Math.Pow(cy.Radius, 2) * cy.Height;
        }
    }
}