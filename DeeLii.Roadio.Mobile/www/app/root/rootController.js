﻿roadioMobile.controller('rootController', ['$scope', '$state', function ($scope, $state) {
    $scope.greeting = 'Hola!';
    $scope.homeButtonUrl = 'images/back-home-button.png';

    $scope.isRootController = function () {
        if ($state.current.name == "root") {
            return true;
        }
        else {
            return false;
        }
    }
}]);