using Autofac;
using MyJetWallet.Sdk.NoSql;
using MyNoSqlServer.DataReader;

namespace MyJetWallet.TestUsers;

public static class AutofacHelper
{
    public static void RegisterTestUsersReader(this ContainerBuilder builder, IMyNoSqlSubscriber client)
    {
        builder.RegisterMyNoSqlReader<TestUserNoSQlEntity>(client, TestUserNoSQlEntity.TableName, NoSqlDataWaitMode.None);
    }
}