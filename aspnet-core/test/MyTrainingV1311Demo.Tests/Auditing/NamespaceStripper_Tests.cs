using MyTrainingV1311Demo.Auditing;
using MyTrainingV1311Demo.Test.Base;
using Shouldly;
using Xunit;

namespace MyTrainingV1311Demo.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("MyTrainingV1311Demo.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("MyTrainingV1311Demo.Auditing.GenericEntityService`1[[MyTrainingV1311Demo.Storage.BinaryObject, MyTrainingV1311Demo.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("MyTrainingV1311Demo.Auditing.XEntityService`1[MyTrainingV1311Demo.Auditing.AService`5[[MyTrainingV1311Demo.Storage.BinaryObject, MyTrainingV1311Demo.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[MyTrainingV1311Demo.Storage.TestObject, MyTrainingV1311Demo.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
