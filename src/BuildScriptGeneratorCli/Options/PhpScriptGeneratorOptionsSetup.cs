﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// --------------------------------------------------------------------------------------------

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Oryx.BuildScriptGenerator.Php;

namespace Microsoft.Oryx.BuildScriptGeneratorCli.Options
{
    public class PhpScriptGeneratorOptionsSetup : OptionsSetupBase, IConfigureOptions<PhpScriptGeneratorOptions>
    {
        public PhpScriptGeneratorOptionsSetup(IConfiguration configuration) 
            : base(configuration)
        {
        }

        public void Configure(PhpScriptGeneratorOptions options)
        {
            options.PhpVersion = GetStringValue(SettingsKeys.PhpVersion);
        }
    }
}