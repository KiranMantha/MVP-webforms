using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Presenters
{
    public class CirclePresenter
    {
        IView mview;
        public CirclePresenter(IView view)
        {
            mview = view;
        }
        public string CalculateCircleArea()
        {
            CircleModel model = new CircleModel();
            mview.ResultText = model.getArea(double.Parse(mview.RadiusText)).ToString();
            return mview.ResultText.ToString();
        }
    }
}