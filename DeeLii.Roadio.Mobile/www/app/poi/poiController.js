roadioMobile.controller('poiController', ['$scope', '$state', function ($scope, $state) {
    $scope.greeting = 'Hola!';
    $scope.imagePath = '';
    function init() {
    };

    document.addEventListener("deviceready", function () {
        $cordovaPlugin.someFunction().then(success, error);
    }, false);

    $scope.capturePoi = function () {
        navigator.camera.getPicture(onSuccess, onFail, {
            quality: 10,
            destinationType: Camera.DestinationType.FILE_URI
        });

        function onSuccess(imageUrl) {
            $scope.imagePath = imageUrl;
        }

        function onFail(message) {
            alert('Failed because: ' + message);
        }
    };
}]);