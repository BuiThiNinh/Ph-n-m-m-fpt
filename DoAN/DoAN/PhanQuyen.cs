using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN
{
      public class PhanQuyen
    {
          QL_FPT_SHOPDataContext ql = new QL_FPT_SHOPDataContext();
          public List<QL_PHANQUYEN> laydsmanhinh(String pmanhom)
          {
              return ql.QL_PHANQUYENs.Where(t => t.MANHOM == pmanhom).ToList<QL_PHANQUYEN>();
          }
          public QLND_NHOMND laymanhom(String pTendn)
          {
              return ql.QLND_NHOMNDs.Where(t => t.TENDN == pTendn).FirstOrDefault();
          }

          

    }
}
