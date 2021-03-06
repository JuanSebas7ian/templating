using System;
using System.Collections.Generic;

namespace Microsoft.TemplateEngine.Abstractions.TemplateUpdates
{
    // Base interface for identifying a template or set of templates.
    // Concretes could be for template packs (nupkgs, zips, etc.), or for individual templates.
    // Basically anything which could be a logical unit of templates.
    public interface IInstallUnitDescriptor
    {
        Guid DescriptorId { get; }

        string Identifier { get; }

        Guid FactoryId { get; }

        Guid MountPointId { get; }

        IReadOnlyDictionary<string, string> Details { get; }

        string UninstallString { get; }

        IReadOnlyList<string> DetailKeysDisplayOrder { get; }
    }
}
