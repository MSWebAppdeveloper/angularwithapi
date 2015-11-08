(function () {
    'use strict';
    angular.module('CS_test')
           .controller('AppEditSalesController', AppEditSalesController);

    AppEditSalesController.$inject = ["SubjectService","$state","$stateParams","$scope"];

    function AppEditSalesController(SubjectService, $state, $stateParams, $scope) {
        $scope.Sale = { SalesDetail: [] };
        $scope.Sale.SubjectId = $stateParams.subjectId;
        $scope.Save = function ()
        {
            SubjectService.addSale($scope.Sale.SubjectId,$scope.Sale).then(function (response) { $state.go('subject.sales') }, function (error) { })
        }
        $scope.AddDetail = function () {
            $scope.Sale.SalesDetail.push({ ProductId: $scope.ProductId, Qty: $scope.Qty, Price: $scope.Price, Amount: $scope.Amount });
        }

        $scope.getItems = function ()
        {
            SubjectService.getItems().then(function (data) { $scope.Items = data; }, function () { })
        }

        $scope.getItems();
    }
})();