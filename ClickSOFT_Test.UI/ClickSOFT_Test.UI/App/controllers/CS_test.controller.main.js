(function () {
    'use strict';
    angular.module('CS_test')
           .controller('MainController', MainController);

    MainController.$inject = ["$scope", "SubjectService"];

    function MainController($scope, SubjectService) {
        

        SubjectService.getSubjects().then(function (subjects) {
            $scope.subjects = subjects;
        }, function (error) {
            console.log(error);
        })
    }
})();