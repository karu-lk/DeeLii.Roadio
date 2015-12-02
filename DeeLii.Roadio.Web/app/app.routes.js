roadioWeb.config(function ($stateProvider, $urlRouterProvider) {
    $stateProvider
    .state('poi-view', {
        url: '/poi-view',
        templateUrl: '../poi/poi-view.html',
        controller: 'poiController',
        data: { pageTitle: 'POI View' }
    })
});