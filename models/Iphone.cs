using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celulares_tipos.models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        public override void AplicativoDeContatos()
        {
            throw new NotImplementedException();
        }

        public override void AplicativoDeMusicas()
        {
            throw new NotImplementedException();
        }

        public override void FazerLigacao()
        {
            throw new NotImplementedException();
        }

        public override void InstalarAplicativo()
        {
            throw new NotImplementedException();
        }
    }
}