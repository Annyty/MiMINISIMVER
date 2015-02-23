(function () {
    var app = angular.module("miniSimverApp", ["ngRoute"]);
    app.config(function ($routeProvider) {
        $routeProvider
           .when('/', {
               templateUrl: "index.html"
           })

            .when('/estado', {
                controller: "estado",
                controllerAs: 'vm',
                templateUrl: "views/estado.html"
            })
        .when('/municipios/:entidadId', {
            controller: "municipio",
            templateUrl: "/views/municipio.html",
            controllerAs: "vm"
        })

        .when('/municipios/:entidadId', {
            controller: "municipio",
            templateUrl: "/views/DatosEstado.html",
            controllerAs: "vm"
        })
           
        .otherwise({
            redirecTo: "/"
        });
    });

}());