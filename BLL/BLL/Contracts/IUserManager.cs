using System;

namespace BLL.Contracts
{
  interface IUserManager
  {

  }

  internal interface IAuditoriaCasos
  {
    CasoMedico Find();
  }

  public class CasoMedico
  {
    public String Codigo { get; set; }
    public DateTime? Fecha { get; set; }
    public String Auditor { get; set; }
    public String Estado { get; set; }
    public String TotalGasto { get; set; }
    public String Titular { get; set; }
  }
}