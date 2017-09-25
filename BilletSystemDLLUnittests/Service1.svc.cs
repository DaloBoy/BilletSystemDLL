using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;
using BilletLibrary;

namespace BilletSystemDLLUnittests
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Billet" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Billet.svc or Billet.svc.cs at the Solution Explorer and start debugging.
    public class Billet : IBillet
    {
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int BilPris()
        {
            var testBil = new Bil();
            return testBil.Pris();
        }

        public int BilPrisMedBizz()
        {
            var bil = new Bil();
            bil.BroBizz = true;
            return bil.Pris();
        }

        public int BilPrisØresund()
        {
            var bil = new BilØreSund();
            return bil.Pris();
        }

        public int BilPrisØresundBizz()
        {
            var bil = new Bil();
            bil.BroBizz = true;
            return bil.Pris();
        }

        public int MCPris()
        {
            var mc = new MC();
            return mc.Pris();
        }

        public int MCØresund()
        {
            var mc = new MC();
            return mc.Pris();
        }

        public int MCPrisØresunBIzz()
        {
            var mc = new MC();
            mc.BroBizz = true;
            return mc.Pris();
        }

        public int MCBrobiz()
        {
            var mc = new MC();
            mc.BroBizz = true;
            return mc.Pris();
        }
    }
}
