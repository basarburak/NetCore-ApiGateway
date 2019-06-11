# NetCore-ApiGateway
<b> #Product Api  </b>  <br>
  /localhost:5000/api/v1.0/category <br>
  /localhost:5000/api/v2.0/category
  
  ```ruby
     [ApiVersion("1.0")]
     [ApiController]
     [Route("api/v{version:apiVersion}/[controller]")]
     public class CategoryController : ControllerBase
```

<b> #Ocelot Api Gateway </b> <br>
/localhost:9000/v1/category <br>
/localhost:9000/v2/category

```ruby
  "ReRoutes": [
    {
      "DownstreamPathTemplate": "/api/{version}/category",
      "UpstreamPathTemplate": "/{version}/category",
      "UpstreamHttpMethod": [
        "Get"
      ],
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5000
        }
      ]
    }
  ]
```
