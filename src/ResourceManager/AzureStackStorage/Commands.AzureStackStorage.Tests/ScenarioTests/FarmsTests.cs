// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.AzureStack.Commands.StorageAdmin.Test.ScenarioTests
{
    public class FarmsTests
    {
        public FarmsTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            Azure.ServiceManagemenet.Common.Models.XunitTracingInterceptor.AddToContext(new Azure.ServiceManagemenet.Common.Models.XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetFarm()
        {
            TestsController.NewInstance.RunPsTest("Test-GetFarm");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListFarms()
        {
            TestsController.NewInstance.RunPsTest("Test-ListFarms");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetFarm()
        {
            TestsController.NewInstance.RunPsTest("Test-SetFarm");
        }

        //[Fact]
        //[Trait(Category.AcceptanceType, Category.CheckIn)]
        //public void TestGetFarms()
        //{
        //    TestsController.NewInstance.RunPsTest("Test-GetFarms");
        //}

        //[Fact]
        //[Trait(Category.AcceptanceType, Category.CheckIn)]
        //public void TestGetAlertHistory()
        //{
        //    TestsController.NewInstance.RunPsTest("Test-GetAlertHistory");
        //}
    }
}