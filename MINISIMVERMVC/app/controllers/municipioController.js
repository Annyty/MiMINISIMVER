(function () {
    estadoController.$inject = ['$routeParams', 'municipioFactory'];

    function estadoController($routeParams, municipioFactory) {
        // $scope.clientes = clientesFactory.regresarClientes();
        var vm = this;
        vm.municipioId = $routeParams.municipioId;
        vm.municipios = null;
       
        var inicializar = function () {
            municipioFactory.regresarMunicipios()
                .success(function (data, status, headers, config) {
                    vm.municipios = data;
                    
                }).
                error(function (data, status, headers, config) {
                    alert("ya valió regresarMunicipios");
                });
        }

        inicializar();
    }

    angular.module('miniSimverApp').controller('municipio', municipioController);

}());