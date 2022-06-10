using MyNoSqlServer.Abstractions;

namespace MyJetWallet.TestUsers;

public class TestUserNoSQlEntity: MyNoSqlDbEntity
{
    public static string TableName = "myjetwallet-testusers";
    public static string GeneratePartitionKey() => "test-users";
    public static string GenerateRowKey(string clientId) => clientId;

    public static TestUserNoSQlEntity Create(string clientId)
    {
        return new TestUserNoSQlEntity()
        {
            PartitionKey = GeneratePartitionKey(),
            RowKey = GenerateRowKey(clientId)
        };
    }
}