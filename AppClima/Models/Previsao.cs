using System;
using System.Collections.Generic;
using System.Text;

namespace AppClima.Models
{
    public class Previsao
    {
        private string cidade;
        private string estado;
        private DateTime atualizado;
        private List<Clima> clima;
    }
}
