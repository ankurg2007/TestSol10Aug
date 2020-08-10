using Infra.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Interfaces
{
  public interface IPackingSlip
    {

        bool AddFeeVideo(PackingSlip packingSlip);
        bool GenerateDuplicatePackingSlip(PackingSlip packingSlip);

        bool GeneratePackingSlip();



    }
}
