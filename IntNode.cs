using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDonPhamVanQuoc22DH114707
{
    internal class IntNode
    {
        private int data;
        private IntNode next;

        public int Data { get => data; set => data = value; }
        internal IntNode Next { get => next; set => next = value; }
        public IntNode(int x=0)    
        {
            data = x;
            next = null;
         }
    }
}
