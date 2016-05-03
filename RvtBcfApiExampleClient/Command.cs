using System;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RvtBcfApiExampleClient
{
  [Transaction(TransactionMode.ReadOnly)]
  public class Command : IExternalCommand
  {
    public Result Execute( 
      ExternalCommandData commandData, 
      ref string message, 
      ElementSet elements )
    {
      throw new NotImplementedException();
    }
  }
}
