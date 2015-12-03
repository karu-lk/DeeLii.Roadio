roadioMobile.controller('poiController', ['$scope', '$state', '$cordovaCamera', '$cordovaGeolocation', function ($scope, $state, $cordovaCamera, $cordovaGeolocation) {
    $scope.greeting = 'Hola!';
    $scope.captures = [];
    $scope.captureCount = undefined;

    function init() {
        $scope.captureCount = 0;
        $scope.captureButtonTitle = "Capture POI";
        for (var i = 0; i < 3; i++) {
            $scope.captures.push("images/empty-photo-placeholder.png");
        }
    };

    init();

    $scope.capturePoi = function () {
        document.addEventListener("deviceready", function () {
            var options = {
                quality: 50,
                destinationType: Camera.DestinationType.DATA_URL,
                sourceType: Camera.PictureSourceType.CAMERA,
                allowEdit: true,
                encodingType: Camera.EncodingType.JPEG,
                targetWidth: 100,
                targetHeight: 100,
                popoverOptions: CameraPopoverOptions,
                saveToPhotoAlbum: false,
                correctOrientation: true
            };
            $cordovaCamera.getPicture(options).then(function (captureData) {
                $scope.captures[$scope.captureCount] = "data:image/jpeg;base64," + captureData;

                //$cordovaProgress.showSimple(true);
                getLocation($cordovaGeolocation);
                //$cordovaProgress.hide();

                $scope.captureCount++;
            }, function (err) {
                alert(err);
            });
        }, false);
    };

    function getLocation($cordovaGeolocation) {
        var posOptions = { timeout: 10000, enableHighAccuracy: false };
        $cordovaGeolocation
          .getCurrentPosition(posOptions)
          .then(function (position) {
              $scope.lat = position.coords.latitude;
              $scope.long = position.coords.longitude;
          }, function (err) {
              alert(err);
          });
    };
}]);