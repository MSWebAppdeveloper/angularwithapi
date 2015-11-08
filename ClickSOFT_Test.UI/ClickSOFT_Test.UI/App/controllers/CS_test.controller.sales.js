(function () {
    'use strict';
    angular.module('CS_test')
           .controller('AppSalesController', AppSalesController);

    AppSalesController.$inject = ["SubjectService","$stateParams","$scope"];

    function AppSalesController(SubjectService, $stateParams, $scope) {
        $scope.load = function () {
            SubjectService.subjectSales($stateParams.subjectId).then(function (data) { debugger; $scope.Sales = data }, function (error) { })
        }
        $scope.load();
    }
})();