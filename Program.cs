using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;

var client = new AmazonCognitoIdentityProviderClient();
var result = await client.AdminUpdateUserAttributesAsync(new AdminUpdateUserAttributesRequest
{
    UserPoolId = "ap-northeast-1_zVyUOeuZo",
    Username = "hoge-user1",
    UserAttributes = new List<AttributeType>
    {
        new AttributeType { Name = "name", Value = "user111"},
        new AttributeType { Name = "nickname", Value = "hogehogehoge"}
    }
});

Console.WriteLine(result.HttpStatusCode);