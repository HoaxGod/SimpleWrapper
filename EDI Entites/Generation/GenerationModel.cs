using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Entites.Generation
{
    public class GenerationModel
    {
        public List<_837GenerationEntity> GenarationEntitesList { get; set; }

        public GenerationModel()
        {
            this.GenarationEntitesList = new List<_837GenerationEntity>();
        }

        public string FormType { get; set; }

        public string UserName { get; set; }
    }
}
