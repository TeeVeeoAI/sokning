namespace sokning
{
    public class Person
    {
        private int personnr;
        private string namn;

        public Person(int p, string n)
        {
            personnr = p;
            namn = n;
        }

        public string Namn
        {
            set{ namn = value;  }
            get{ return namn;   }
        }

        public int Personnr
        {
            set{ personnr = value;  }
            get{ return personnr;   }
        }
    }
}