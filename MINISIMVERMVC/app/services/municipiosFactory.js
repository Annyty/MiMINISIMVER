(function () {

    municipioFactory.$inject = ["$http"];

    function municipioFactory($http) {

        var factory = {};
        console.log("Entro al factory");
        factory.regresarMunicipios = function () {
            
            return $http.get('/api/muicipio/');

        }

        //factory.obtenerEstadoPorID = function (estadoId) {

        //    console.log(estadoId);
        //    return $http.get('/Estado/ObtenerEstadoPorId/' + estadoId)
        //}

        return factory;
    }

    angular.module('miniSimverApp').factory('municipioFactory', municipioFactory);

}());