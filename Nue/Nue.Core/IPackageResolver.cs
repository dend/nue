﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nue.Core
{
    public interface IPackageResolver
    {
        // will merge the current package information mapping into pkgInfoMap
        bool CopyBinarySet(PackageAtom package, RunSettings runSettings, PackageInfomarionMapping pkgInfoMap, AssemblyMappingPackageInformation pkgInfoMapofdepAssembly, string outputPrefix = "");
    }
}
