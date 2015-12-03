roadioMobile.controller('poiController', ['$scope', '$state', '$cordovaCamera', function ($scope, $state, $cordovaCamera) {
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
                $scope.captures[$scope.captureCount]="data:image/jpeg;base64," + captureData;
                $scope.captureCount++;
            }, function (err) {
                alert(err);
            });
        }, false);
    };
}]);