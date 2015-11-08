(function () {
    'use strict';
    angular.module('CS_test')
           .config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
        // For any unmatched url, send to /
        $urlRouterProvider.otherwise("/")
        $stateProvider
            .state('dashboard',
            {
                url: '/',
                templateUrl: "App/views/dashboard.html",
                controller: "AppDashboardController"
            })        
            .state('subject',
            {
                url: '/subject/:subjectId',
                templateUrl: "App/views/subject.html",
                controller: "AppSubjectController"
            }).state('subject.sales',
            {
                url: '/sales',
                templateUrl: "App/views/sales.html",
                controller: "AppSalesController"
            }).state('subject.sales-add',
            {
                url: '/add-sale',
                templateUrl: "App/views/salesadd.html",
                controller: "AppEditSalesController"
            })
               .state('subject.supplies',
            {
                url: '/supplies',
                templateUrl: "App/views/supplies.html",
            })
    }]);
})();
