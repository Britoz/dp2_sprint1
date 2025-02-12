﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Model
{
    class SalesProductModel
    {
        private string _id;
        private string _name;
        private int _serialnumber;
        private int _quantity;
        private string _description;
        private string _dateImport;
        private int _unitprice;

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Serialnumber
        {
            get
            {
                return _serialnumber;
            }

            set
            {
                _serialnumber = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }

        public int Unitprice
        {
            get
            {
                return _unitprice;
            }

            set
            {
                _unitprice = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string DateImport
        {
            get
            {
                return _dateImport;
            }

            set
            {
                _dateImport = value;
            }
        }

        public SalesProductModel() { }
        public SalesProductModel(string id, string name,string description, int serialnumber, int quantity,int unitprice,
            string dateImport)
        {
            Id = id;
            Name = name;
            Serialnumber = serialnumber;
            Quantity = quantity;
            Unitprice = unitprice;
            Description = description;
            DateImport = dateImport;
        }
    }
}
