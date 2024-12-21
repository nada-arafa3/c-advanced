using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced
{
    public class book
    {
      
        #region properties

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal price { get; set; }
        #endregion


        #region constructors 


        public book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            this.price = price;
        }


        #endregion

        #region methods

        public override string ToString() {
        StringBuilder sb = new StringBuilder(Authors[0]);

            for (int i = 1; i < Authors.Length; i++)
            {
                sb.Append(Authors[i]);
            }
            return $"ISBN:{ISBN} /n {Title}.... ";
        
        }

        #endregion

    }
}
