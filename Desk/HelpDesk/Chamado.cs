using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public int Serie {  get; set; }
        public string DescricaoProblema { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
