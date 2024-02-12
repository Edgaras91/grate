﻿using TestCommon.TestInfrastructure;

namespace Oracle.Running_MigrationScripts;

[Collection(nameof(OracleTestContainer))]
// ReSharper disable once InconsistentNaming
public class Anytime_scripts(IGrateTestContext testContext, ITestOutputHelper testOutput)
    : TestCommon.Generic.Running_MigrationScripts.Anytime_scripts(testContext, testOutput);
