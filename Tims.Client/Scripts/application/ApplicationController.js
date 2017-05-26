/// <reference path="../vendor/angular.js" />
/// <reference path="service.js" />
/// <reference path="../App/AppController.js" />
app.controller("applicationController", function ($scope,$http) {
    $scope.Msg = "kiran"
    getAll();
    
    function getAll()
    {
        $http({
            method: "GET",
            url: "http://localhost:81/api/Application"
        }).then(function mySucces(response) {
            alert("success");
            $scope.Applications = response.data;
        }, function myError(response) {
            alert(response);
            console.log('Oops! Something went wrong while fetching the data.')
        });
    }
    var success = function success(d)
    {
       
    }
    var onerror = function onerror(error)
    {
        alert(error);
        console.log('Oops! Something went wrong while fetching the data.')
    }
});