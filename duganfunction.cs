var azureServiceTokenProvider = new AzureServiceTokenProvider();
var keyvaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
            
var secretValue = await keyvaultClient.GetSecretAsync($"https://{myVault}.vault.azure.net/", "MyFunctionSecret");
            
return req.CreateResponse(HttpStatusCode.OK, $"Hello World! This is my secret value: `{secretValue.Value}`.");
