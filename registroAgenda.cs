using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_compromissos
{
	public class registroAgenda
	{
		//eessas propriedades serao preenchidas e esse conjunto de informacao vai para uma lista apos preenchido, 
		//e outra assim por diante a cada registro
		public string compromisso { get; set; }
		public string horario { get; set; }
		public string DiaDaSemana { get; set; }
		public string duracao  { get; set; }
}
}
