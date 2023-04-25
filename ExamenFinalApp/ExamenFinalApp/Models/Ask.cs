using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalApp.Models
{
    public  class Ask
    {
         
            

            public long AskId { get; set; }
            public DateTime Date { get; set; }
            public string Ask1 { get; set; } = null;
            public int UserId { get; set; }
            public int AskStatusId { get; set; }
            public bool IsStrike { get; set; }
            public string ImageUrl { get; set; }
            public string AskDetail { get; set; }

            public virtual AskStatus? AskStatus { get; set; } = null;
            public virtual User? User { get; set; } = null;
             
        




    }
}
