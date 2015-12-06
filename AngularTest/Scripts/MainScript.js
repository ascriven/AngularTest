var app5 = angular.module('menuItemApp', ['ngAnimate','ui.bootstrap']);

app5.controller('menuItemCtrl', function ($scope, $http, $window) {
    $scope.newMenuItem = { ID: null };
    $scope.refresh = function () {
        $http.get("/api/MenuItem/GetMenuItems").success(function (response) { $scope.menuItems = response; });
        };
    $scope.add = function () {
        $http.post("/api/MenuItem/AddMenuItem", $scope.newMenuItem).success(function (data, status, headers, config) {
                alert('Product Added Successfully');
                $scope.refresh();
            }).error(function (data, status, headers, config) {
                alert("Unable To Add Product.");
                $scope.refresh();
            });
        $scope.menuItems.push($scope.newMenuItem)
        $scope.newMenuItem = { ID: null };
        };
    $scope.refresh();
    });