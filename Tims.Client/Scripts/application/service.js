/// <reference path="../angular.js" />
/// <reference path="../app/appModule.js" />

app.service("ApiService",function($http)
{
    this.getSubs = function()
    {
        return $http.get("api/application");
    }
})