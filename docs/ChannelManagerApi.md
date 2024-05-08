# channelmanager.Api.ChannelManagerApi

All URIs are relative to *https://channel.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChannelManagerCreateAssociation**](ChannelManagerApi.md#channelmanagercreateassociation) | **POST** /channelmanager.ChannelManager/CreateAssociation | CreateAssociation |
| [**ChannelManagerCreateChannel**](ChannelManagerApi.md#channelmanagercreatechannel) | **POST** /channelmanager.ChannelManager/CreateChannel | CreateChannel |
| [**ChannelManagerCreateMarket**](ChannelManagerApi.md#channelmanagercreatemarket) | **POST** /channelmanager.ChannelManager/CreateMarket | CreateMarket |
| [**ChannelManagerDeleteAssociation**](ChannelManagerApi.md#channelmanagerdeleteassociation) | **POST** /channelmanager.ChannelManager/DeleteAssociation | DeleteAssociation |
| [**ChannelManagerDeleteChannel**](ChannelManagerApi.md#channelmanagerdeletechannel) | **POST** /channelmanager.ChannelManager/DeleteChannel | DeleteChannel |
| [**ChannelManagerDeleteMarket**](ChannelManagerApi.md#channelmanagerdeletemarket) | **POST** /channelmanager.ChannelManager/DeleteMarket | DeleteMarket |
| [**ChannelManagerGetChannel**](ChannelManagerApi.md#channelmanagergetchannel) | **POST** /channelmanager.ChannelManager/GetChannel | GetChannel |
| [**ChannelManagerGetChannelWithAssociations**](ChannelManagerApi.md#channelmanagergetchannelwithassociations) | **POST** /channelmanager.ChannelManager/GetChannelWithAssociations | GetChannelWithAssociations |
| [**ChannelManagerGetMarket**](ChannelManagerApi.md#channelmanagergetmarket) | **POST** /channelmanager.ChannelManager/GetMarket | GetMarket |
| [**ChannelManagerGetMarketWithAssociations**](ChannelManagerApi.md#channelmanagergetmarketwithassociations) | **POST** /channelmanager.ChannelManager/GetMarketWithAssociations | GetMarketWithAssociations |
| [**ChannelManagerListChannels**](ChannelManagerApi.md#channelmanagerlistchannels) | **POST** /channelmanager.ChannelManager/ListChannels | ListChannels |
| [**ChannelManagerListChannelsWithAssociations**](ChannelManagerApi.md#channelmanagerlistchannelswithassociations) | **POST** /channelmanager.ChannelManager/ListChannelsWithAssociations | ListChannelsWithAssociations |
| [**ChannelManagerListMarkets**](ChannelManagerApi.md#channelmanagerlistmarkets) | **POST** /channelmanager.ChannelManager/ListMarkets | ListMarkets |
| [**ChannelManagerListMarketsWithAssociations**](ChannelManagerApi.md#channelmanagerlistmarketswithassociations) | **POST** /channelmanager.ChannelManager/ListMarketsWithAssociations | ListMarketsWithAssociations |
| [**ChannelManagerUpdateChannel**](ChannelManagerApi.md#channelmanagerupdatechannel) | **POST** /channelmanager.ChannelManager/UpdateChannel | UpdateChannel |
| [**ChannelManagerUpdateMarket**](ChannelManagerApi.md#channelmanagerupdatemarket) | **POST** /channelmanager.ChannelManager/UpdateMarket | UpdateMarket |

<a id="channelmanagercreateassociation"></a>
# **ChannelManagerCreateAssociation**
> ChannelmanagerAssociationResponse ChannelManagerCreateAssociation (ChannelmanagerCreateAssociationRequest body)

CreateAssociation

Create a new association between a channel and a market or entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerCreateAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerCreateAssociationRequest(); // ChannelmanagerCreateAssociationRequest | 

            try
            {
                // CreateAssociation
                ChannelmanagerAssociationResponse result = apiInstance.ChannelManagerCreateAssociation(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerCreateAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerCreateAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateAssociation
    ApiResponse<ChannelmanagerAssociationResponse> response = apiInstance.ChannelManagerCreateAssociationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerCreateAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerCreateAssociationRequest**](ChannelmanagerCreateAssociationRequest.md) |  |  |

### Return type

[**ChannelmanagerAssociationResponse**](ChannelmanagerAssociationResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagercreatechannel"></a>
# **ChannelManagerCreateChannel**
> ChannelmanagerChannelResponse ChannelManagerCreateChannel (ChannelmanagerCreateChannelRequest body)

CreateChannel

Create a new channel

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerCreateChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerCreateChannelRequest(); // ChannelmanagerCreateChannelRequest | 

            try
            {
                // CreateChannel
                ChannelmanagerChannelResponse result = apiInstance.ChannelManagerCreateChannel(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerCreateChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerCreateChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateChannel
    ApiResponse<ChannelmanagerChannelResponse> response = apiInstance.ChannelManagerCreateChannelWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerCreateChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerCreateChannelRequest**](ChannelmanagerCreateChannelRequest.md) |  |  |

### Return type

[**ChannelmanagerChannelResponse**](ChannelmanagerChannelResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagercreatemarket"></a>
# **ChannelManagerCreateMarket**
> ChannelmanagerMarketResponse ChannelManagerCreateMarket (ChannelmanagerCreateMarketRequest body)

CreateMarket

Create a new market

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerCreateMarketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerCreateMarketRequest(); // ChannelmanagerCreateMarketRequest | 

            try
            {
                // CreateMarket
                ChannelmanagerMarketResponse result = apiInstance.ChannelManagerCreateMarket(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerCreateMarket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerCreateMarketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateMarket
    ApiResponse<ChannelmanagerMarketResponse> response = apiInstance.ChannelManagerCreateMarketWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerCreateMarketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerCreateMarketRequest**](ChannelmanagerCreateMarketRequest.md) |  |  |

### Return type

[**ChannelmanagerMarketResponse**](ChannelmanagerMarketResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerdeleteassociation"></a>
# **ChannelManagerDeleteAssociation**
> Object ChannelManagerDeleteAssociation (ChannelmanagerDeleteAssociationRequest body)

DeleteAssociation

Delete an existing association between a channel and a market or entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerDeleteAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerDeleteAssociationRequest(); // ChannelmanagerDeleteAssociationRequest | 

            try
            {
                // DeleteAssociation
                Object result = apiInstance.ChannelManagerDeleteAssociation(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerDeleteAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerDeleteAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteAssociation
    ApiResponse<Object> response = apiInstance.ChannelManagerDeleteAssociationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerDeleteAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerDeleteAssociationRequest**](ChannelmanagerDeleteAssociationRequest.md) |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerdeletechannel"></a>
# **ChannelManagerDeleteChannel**
> Object ChannelManagerDeleteChannel (ChannelmanagerDeleteChannelRequest body)

DeleteChannel

Soft delete an existing channel

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerDeleteChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerDeleteChannelRequest(); // ChannelmanagerDeleteChannelRequest | 

            try
            {
                // DeleteChannel
                Object result = apiInstance.ChannelManagerDeleteChannel(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerDeleteChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerDeleteChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteChannel
    ApiResponse<Object> response = apiInstance.ChannelManagerDeleteChannelWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerDeleteChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerDeleteChannelRequest**](ChannelmanagerDeleteChannelRequest.md) |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerdeletemarket"></a>
# **ChannelManagerDeleteMarket**
> Object ChannelManagerDeleteMarket (ChannelmanagerDeleteMarketRequest body)

DeleteMarket

Soft delete an existing market

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerDeleteMarketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerDeleteMarketRequest(); // ChannelmanagerDeleteMarketRequest | 

            try
            {
                // DeleteMarket
                Object result = apiInstance.ChannelManagerDeleteMarket(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerDeleteMarket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerDeleteMarketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteMarket
    ApiResponse<Object> response = apiInstance.ChannelManagerDeleteMarketWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerDeleteMarketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerDeleteMarketRequest**](ChannelmanagerDeleteMarketRequest.md) |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagergetchannel"></a>
# **ChannelManagerGetChannel**
> ChannelmanagerChannelResponse ChannelManagerGetChannel (ChannelmanagerGetChannelRequest body)

GetChannel

Get an existing channel

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerGetChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerGetChannelRequest(); // ChannelmanagerGetChannelRequest | 

            try
            {
                // GetChannel
                ChannelmanagerChannelResponse result = apiInstance.ChannelManagerGetChannel(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerGetChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetChannel
    ApiResponse<ChannelmanagerChannelResponse> response = apiInstance.ChannelManagerGetChannelWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerGetChannelRequest**](ChannelmanagerGetChannelRequest.md) |  |  |

### Return type

[**ChannelmanagerChannelResponse**](ChannelmanagerChannelResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagergetchannelwithassociations"></a>
# **ChannelManagerGetChannelWithAssociations**
> ChannelmanagerChannelResponseWithAssociations ChannelManagerGetChannelWithAssociations (ChannelmanagerGetChannelWithAssociationsRequest body)

GetChannelWithAssociations

Get an existing channel with associations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerGetChannelWithAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerGetChannelWithAssociationsRequest(); // ChannelmanagerGetChannelWithAssociationsRequest | 

            try
            {
                // GetChannelWithAssociations
                ChannelmanagerChannelResponseWithAssociations result = apiInstance.ChannelManagerGetChannelWithAssociations(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetChannelWithAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerGetChannelWithAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetChannelWithAssociations
    ApiResponse<ChannelmanagerChannelResponseWithAssociations> response = apiInstance.ChannelManagerGetChannelWithAssociationsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetChannelWithAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerGetChannelWithAssociationsRequest**](ChannelmanagerGetChannelWithAssociationsRequest.md) |  |  |

### Return type

[**ChannelmanagerChannelResponseWithAssociations**](ChannelmanagerChannelResponseWithAssociations.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagergetmarket"></a>
# **ChannelManagerGetMarket**
> ChannelmanagerMarketResponse ChannelManagerGetMarket (ChannelmanagerGetMarketRequest body)

GetMarket

Get an existing market

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerGetMarketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerGetMarketRequest(); // ChannelmanagerGetMarketRequest | 

            try
            {
                // GetMarket
                ChannelmanagerMarketResponse result = apiInstance.ChannelManagerGetMarket(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetMarket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerGetMarketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetMarket
    ApiResponse<ChannelmanagerMarketResponse> response = apiInstance.ChannelManagerGetMarketWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetMarketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerGetMarketRequest**](ChannelmanagerGetMarketRequest.md) |  |  |

### Return type

[**ChannelmanagerMarketResponse**](ChannelmanagerMarketResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagergetmarketwithassociations"></a>
# **ChannelManagerGetMarketWithAssociations**
> ChannelmanagerMarketResponseWithAssociations ChannelManagerGetMarketWithAssociations (ChannelmanagerGetMarketWithAssociationsRequest body)

GetMarketWithAssociations

Get an existing market with associations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerGetMarketWithAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerGetMarketWithAssociationsRequest(); // ChannelmanagerGetMarketWithAssociationsRequest | 

            try
            {
                // GetMarketWithAssociations
                ChannelmanagerMarketResponseWithAssociations result = apiInstance.ChannelManagerGetMarketWithAssociations(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetMarketWithAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerGetMarketWithAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetMarketWithAssociations
    ApiResponse<ChannelmanagerMarketResponseWithAssociations> response = apiInstance.ChannelManagerGetMarketWithAssociationsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerGetMarketWithAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerGetMarketWithAssociationsRequest**](ChannelmanagerGetMarketWithAssociationsRequest.md) |  |  |

### Return type

[**ChannelmanagerMarketResponseWithAssociations**](ChannelmanagerMarketResponseWithAssociations.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerlistchannels"></a>
# **ChannelManagerListChannels**
> ChannelmanagerListChannelsResponse ChannelManagerListChannels (ChannelmanagerListChannelsRequest body)

ListChannels

List all channels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerListChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerListChannelsRequest(); // ChannelmanagerListChannelsRequest | 

            try
            {
                // ListChannels
                ChannelmanagerListChannelsResponse result = apiInstance.ChannelManagerListChannels(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListChannels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerListChannelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListChannels
    ApiResponse<ChannelmanagerListChannelsResponse> response = apiInstance.ChannelManagerListChannelsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListChannelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerListChannelsRequest**](ChannelmanagerListChannelsRequest.md) |  |  |

### Return type

[**ChannelmanagerListChannelsResponse**](ChannelmanagerListChannelsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerlistchannelswithassociations"></a>
# **ChannelManagerListChannelsWithAssociations**
> ChannelmanagerListChannelsWithAssociationsResponse ChannelManagerListChannelsWithAssociations (ChannelmanagerListChannelsWithAssociationsRequest body)

ListChannelsWithAssociations

List all channels with associations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerListChannelsWithAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerListChannelsWithAssociationsRequest(); // ChannelmanagerListChannelsWithAssociationsRequest | 

            try
            {
                // ListChannelsWithAssociations
                ChannelmanagerListChannelsWithAssociationsResponse result = apiInstance.ChannelManagerListChannelsWithAssociations(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListChannelsWithAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerListChannelsWithAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListChannelsWithAssociations
    ApiResponse<ChannelmanagerListChannelsWithAssociationsResponse> response = apiInstance.ChannelManagerListChannelsWithAssociationsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListChannelsWithAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerListChannelsWithAssociationsRequest**](ChannelmanagerListChannelsWithAssociationsRequest.md) |  |  |

### Return type

[**ChannelmanagerListChannelsWithAssociationsResponse**](ChannelmanagerListChannelsWithAssociationsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerlistmarkets"></a>
# **ChannelManagerListMarkets**
> ChannelmanagerListMarketsResponse ChannelManagerListMarkets (ChannelmanagerListMarketsRequest body)

ListMarkets

List all markets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerListMarketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerListMarketsRequest(); // ChannelmanagerListMarketsRequest | 

            try
            {
                // ListMarkets
                ChannelmanagerListMarketsResponse result = apiInstance.ChannelManagerListMarkets(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListMarkets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerListMarketsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMarkets
    ApiResponse<ChannelmanagerListMarketsResponse> response = apiInstance.ChannelManagerListMarketsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListMarketsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerListMarketsRequest**](ChannelmanagerListMarketsRequest.md) |  |  |

### Return type

[**ChannelmanagerListMarketsResponse**](ChannelmanagerListMarketsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerlistmarketswithassociations"></a>
# **ChannelManagerListMarketsWithAssociations**
> ChannelmanagerListMarketsWithAssociationsResponse ChannelManagerListMarketsWithAssociations (ChannelmanagerListMarketsWithAssociationsRequest body)

ListMarketsWithAssociations

List all markets with associations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerListMarketsWithAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerListMarketsWithAssociationsRequest(); // ChannelmanagerListMarketsWithAssociationsRequest | 

            try
            {
                // ListMarketsWithAssociations
                ChannelmanagerListMarketsWithAssociationsResponse result = apiInstance.ChannelManagerListMarketsWithAssociations(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListMarketsWithAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerListMarketsWithAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMarketsWithAssociations
    ApiResponse<ChannelmanagerListMarketsWithAssociationsResponse> response = apiInstance.ChannelManagerListMarketsWithAssociationsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerListMarketsWithAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerListMarketsWithAssociationsRequest**](ChannelmanagerListMarketsWithAssociationsRequest.md) |  |  |

### Return type

[**ChannelmanagerListMarketsWithAssociationsResponse**](ChannelmanagerListMarketsWithAssociationsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerupdatechannel"></a>
# **ChannelManagerUpdateChannel**
> ChannelmanagerChannelResponse ChannelManagerUpdateChannel (ChannelmanagerUpdateChannelRequest body)

UpdateChannel

Update an existing channel

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerUpdateChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerUpdateChannelRequest(); // ChannelmanagerUpdateChannelRequest | 

            try
            {
                // UpdateChannel
                ChannelmanagerChannelResponse result = apiInstance.ChannelManagerUpdateChannel(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerUpdateChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerUpdateChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateChannel
    ApiResponse<ChannelmanagerChannelResponse> response = apiInstance.ChannelManagerUpdateChannelWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerUpdateChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerUpdateChannelRequest**](ChannelmanagerUpdateChannelRequest.md) |  |  |

### Return type

[**ChannelmanagerChannelResponse**](ChannelmanagerChannelResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="channelmanagerupdatemarket"></a>
# **ChannelManagerUpdateMarket**
> ChannelmanagerMarketResponse ChannelManagerUpdateMarket (ChannelmanagerUpdateMarketRequest body)

UpdateMarket

Update an existing market

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using channelmanager.Api;
using channelmanager.Client;
using channelmanager.Model;

namespace Example
{
    public class ChannelManagerUpdateMarketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://channel.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelManagerApi(config);
            var body = new ChannelmanagerUpdateMarketRequest(); // ChannelmanagerUpdateMarketRequest | 

            try
            {
                // UpdateMarket
                ChannelmanagerMarketResponse result = apiInstance.ChannelManagerUpdateMarket(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerUpdateMarket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChannelManagerUpdateMarketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateMarket
    ApiResponse<ChannelmanagerMarketResponse> response = apiInstance.ChannelManagerUpdateMarketWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelManagerApi.ChannelManagerUpdateMarketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ChannelmanagerUpdateMarketRequest**](ChannelmanagerUpdateMarketRequest.md) |  |  |

### Return type

[**ChannelmanagerMarketResponse**](ChannelmanagerMarketResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

