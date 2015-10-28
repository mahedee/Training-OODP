using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violation
{
   /// <summary>
   /// 
   /// </summary>
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

   
    public class Squre : Rectangle
    {
        private int _height;
        private int _width;


        public override int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                _height = value;
            }
        }
        public override int Height
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AreaCalculator
    {
        public static int CalculateArea(Squre squre)
        {
            return squre.Height * squre.Width;
        }

        public static int CalculateArea(Rectangle rectagle)
        {
            return rectagle.Height * rectagle.Width;
        }

    }

    [TestClass]
    public class CalculateAreaTest
    {
        [TestMethod]
        public void SixFor2x3Rectange()
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            Assert.AreEqual(6, AreaCalculator.CalculateArea(myRectangle));
        }

        [TestMethod]
        public void NineFor3x3Squre()
        {
            var squre = new Squre { Height = 3 };
            Assert.AreEqual(9, AreaCalculator.CalculateArea(squre));
        }

        [TestMethod]
        public void TwentyFor4x5Squre()
        {
            //Failed means not substitutable
            var rectangle = new Squre();
            rectangle.Height = 4;
            rectangle.Width = 5;
            Assert.AreEqual(20, AreaCalculator.CalculateArea(rectangle));

        }
    }

}
