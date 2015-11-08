(function () {
    'use strict';
    angular.module('CS_test')
           .factory('SubjectService', SubjectService);

    SubjectService.$inject = ["$http", "$q"];

    function SubjectService($http, $q) {
        return {
            getSubjects: getSubjects,
            getItems: getItems,
            addSale: addSale,
            subjectSales: subjectSales,
            getSubjectsById: getSubjectsById
        };

        function getSubjects() {
            var deferred = $q.defer();
            $http.get('/data/subjects').success(function (data, headers, status, config) {
                deferred.resolve(data);
            }).error(function (error, headers, status, config) {
                deferred.reject(error);
            });
            return deferred.promise;
        }
        function getSubjectsById(id) {
            var deferred = $q.defer();
            $http.get('/data/subject/'+id).success(function (data, headers, status, config) {
                deferred.resolve(data);
            }).error(function (error, headers, status, config) {
                deferred.reject(error);
            });
            return deferred.promise;
        }

        function getItems() {
            var deferred = $q.defer();
            $http.get('/data/items').success(function (data, headers, status, config) {
                deferred.resolve(data);
            }).error(function (error, headers, status, config) {
                deferred.reject(error);
            });
            return deferred.promise;

        }

        function addSale(subjectId,data)
        {
            var deferred = $q.defer();
            $http.post('/data/subject/' + subjectId + '/addsale',data).success(function (data, headers, status, config) {
                deferred.resolve(data);
            }).error(function (error, headers, status, config) {
                deferred.reject(error);
            });
            return deferred.promise;
        }

        function subjectSales(subjectId) {
            var deferred = $q.defer();
            $http.get('/data/subject/' + subjectId + '/sales').success(function (data, headers, status, config) {
                deferred.resolve(data);
            }).error(function (error, headers, status, config) {
                deferred.reject(error);
            });
            return deferred.promise;
        }
    }
})();