(function () {



    estadoController.$inject = ['$routeParams', 'estadoFactory'];

    function estadoController($routeParams, estadoFactory) {
        // $scope.clientes = clientesFactory.regresarClientes();
        var vm = this;
        vm.estadoId = $routeParams.estadoId;
        vm.estado = null;
        console.log("entro al controlador");
        var inicializar = function () {
            estadoFactory.regresarEstados()
                .success(function (data, status, headers, config) {
                    vm.estados = data;
                    console.log(vm.estados);
                }).
                error(function (data, status, headers, config) {
                    alert("ya valió en regresarEstados");
                });
        }

        estadoFactory.GuardarEstados(vm.estado)
            .success(function (data, status, headers, config) {
                console.log("entro a guardar");
            })
            .error(function (data, status, headers, config) {
                alert("ya valió en GuardarEstados");
            });


        inicializar();
    }

    angular.module('miniSimverApp').controller('estado', estadoController);

}());