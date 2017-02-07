using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class CircleModel : ICircleModel
    {
        public double getArea(double radius) {
            return Math.PI * radius * radius;
        }
    }
}