using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCuartoDia.Models
{
    public class Customer
    {
        private string _customerCode;
        public string CustomerCode
        {
            get{return _customerCode;}
            set { _customerCode = value; }
        }
    }
}