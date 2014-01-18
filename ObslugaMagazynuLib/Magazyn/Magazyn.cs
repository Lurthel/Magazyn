﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Magazyn
{
    public class Magazyn
    {
        public Magazyn()
        {
            nazwa = null;
            lokalizacja = null;
            dataUtworzenia = null;
        }

        public Magazyn(string n, string l) :this()
        {
            nazwa = n;
            lokalizacja = l;
        }

        public Magazyn(int i, string n, string l, string d) : this(n, l)
        {
            id = i;
            dataUtworzenia = d;
        }

        protected int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        protected string nazwa;
        public string Nazwa
        {
            get
            {
                return nazwa;
            }
            set
            {
                if (value.Length > 3)
                {
                    nazwa = value;
                }
                else
                {
                    throw new MagazynException("Nazwa zawiera mniej niż 4 znaki!");
                }
            }
        }

        protected string lokalizacja;
        public string Lokalizacja
        {
            get
            {
                return lokalizacja;
            }
            set
            {
                if (value.Length > 3)
                {
                    lokalizacja = value;
                }
                else
                {
                    throw new MagazynException("Lokalizacja zawiera mniej niż 4 znaki!");
                }
            }
        }

        protected string dataUtworzenia;
        public string DataUtworzenia{
            get
            {
                return dataUtworzenia;
            }
            set
            {
                dataUtworzenia = value;
            }
        }

        public override string ToString()
        {
            return id.ToString() + ". " + nazwa;
        }

        protected bool changeflag;
        public bool ChangedFlag{ get; set; }

    }
}
