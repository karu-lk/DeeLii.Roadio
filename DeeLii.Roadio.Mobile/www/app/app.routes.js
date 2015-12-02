roadioMobile.config(function ($stateProvider, $urlRouterProvider) {
    //http://stackoverflow.com/questions/21840531/using-angular-ui-router-with-phonegap
    $stateProvider

        .state('root', {
            url: '',
            templateUrl: 'app/home/home.html',
            controller: 'homeController',
            data: { pageTitle: 'Create New POI' }
        })

    .state('createPoi', {
        url: '/createPoi',
        templateUrl: 'app/poi/create-poi.html',
        controller: 'poiController',
        data: { pageTitle: 'Create New POI' }
    })
    .state('myPoi', {
        url: '/myPoi',
        templateUrl: 'app/poi/create-poi.html',
        controller: 'poiController',
        data: { pageTitle: 'My POI' }
    })
});