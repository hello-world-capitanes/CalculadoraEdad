using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloVistaControlador.Models
{
    public class AgeModel
    {
        public int years;
        public int months;
        public int days;

        public AgeModel()
        {
        }

        public AgeModel(int years_, int months_, int days_)
        {
            years = years_;
            months = months_;
            days = days_;
        }
    }
}
