using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToFood.Web.Api
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }

        // Lancer la console Anaconda prompt
        /*
(base) C:\>curl https://localhost:44387/api/restaurants
[{"Id":3,"Name":"Mango Grove","Cuisine":2},{"Id":1,"Name":"Scott's Pizza","Cuisine":1},{"Id":2,"Name":"Tersiguels","Cuisine":3}]
(base) C:\>curl https://localhost:44387/api/restaurants -H "Accept: application/json"
[{"Id":3,"Name":"Mango Grove","Cuisine":2},{"Id":1,"Name":"Scott's Pizza","Cuisine":1},{"Id":2,"Name":"Tersiguels","Cuisine":3}]
(base) C:\>curl https://localhost:44387/api/restaurants -H "Accept: application/xml"
<ArrayOfRestaurant xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/OdeToFood.Data.Models"><Restaurant><Cuisine>Indian</Cuisine><Id>3</Id><Name>Mango Grove</Name></Restaurant><Restaurant><Cuisine>Italian</Cuisine><Id>1</Id><Name>Scott's Pizza</Name></Restaurant><Restaurant><Cuisine>French</Cuisine><Id>2</Id><Name>Tersiguels</Name></Restaurant></ArrayOfRestaurant>
         */
        public IEnumerable<Restaurant> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
