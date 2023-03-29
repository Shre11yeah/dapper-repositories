using Repositories.Base;
using Xunit;

namespace Repositories.PostgreSQL.Tests;

public class RepositoriesTests : BaseRepositoriesTests, IClassFixture<DatabaseFixture>
{
    public RepositoriesTests(DatabaseFixture fixture)
        : base(fixture.Db)
    {
    }
}