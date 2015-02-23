(function () {

    estadoFactory.$inject = ["$http"];

    function estadoFactory($http) {

        var factory = {};
        console.log("Entro al factory");
        factory.regresarEstados = function () {
            //return clientes;
            return $http.get('/api/estado/');

        }

        //factory.obtenerEstadoPorID = function (estadoId) {

        //    console.log(estadoId);
        //    return $http.get('/Estado/ObtenerEstadoPorId/' + estadoId)
        //}

        factory.AgregarEstados = function () {
            return $http.get('/api/estado/AgregarEstado/')
        }

        return factory;
    }

    angular.module('miniSimverApp').factory('estadoFactory', estadoFactory);

}());