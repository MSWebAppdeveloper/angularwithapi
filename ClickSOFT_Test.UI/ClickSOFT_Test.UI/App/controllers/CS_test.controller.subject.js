(function () {
    'use strict';
    angular.module('CS_test').
    controller('AppSubjectController', AppSubjectController);

    AppSubjectController.$inject = ["$scope","$stateParams","SubjectService"];

    function AppSubjectController($scope,$stateParams, SubjectService) {
        if($stateParams.subjectId)
        {
            SubjectService.getSubjectsById($stateParams.subjectId).then(function (subject) {
               $scope.subject = subject;
            });
        }
    }
})();