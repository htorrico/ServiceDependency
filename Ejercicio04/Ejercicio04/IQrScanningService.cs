using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
