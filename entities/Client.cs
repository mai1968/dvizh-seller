﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    class Client
    {
        int id;
        string name;
        string phone;

        public Client(int setId, string setName, string setPhone)
        {
            id = setId;
            name = setName;
            phone = setPhone;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPhone()
        {
            return phone;
        }

        public string GetNameAndPhone()
        {
            return name + phone;
        }

        public int GetId()
        {
            return id;
        }
    }
}