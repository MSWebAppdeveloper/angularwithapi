(function () {
    'use strict';
    angular.module('CS_test')
           .directive('subjectDropDownItem', subjectDropDownItem);

    subjectDropDownItem.$inject = [];

    function subjectDropDownItem() {

        var directive = {
            link: link,
            scope: {
                id:'@id',
                name: '@name',             
            },
            replace:true,
            templateUrl: '/App/views/template/subject-drop-down.html',
            restrict: 'E'
        };
        return directive;

        function link(scope, element, attrs) {
            /* */
         
        }
    }
})();