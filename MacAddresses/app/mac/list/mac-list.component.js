"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var mac_service_1 = require("../mac.service");
var http_1 = require("@angular/common/http");
var MacListComponent = (function () {
    function MacListComponent(router, macService, http) {
        this.router = router;
        this.macService = macService;
        this.http = http;
        this.title = 'Macs';
    }
    MacListComponent.prototype.ngOnInit = function () {
        this.macs = this.macService.getMacs();
    };
    MacListComponent.prototype.sendMacsToServer = function () {
        var body = { Macs: this.macs };
        var req = this.http.post('/api/macapi/AddMacs', body);
        req.subscribe();
        this.macs.length = 0;
        this.macs = [];
    };
    return MacListComponent;
}());
MacListComponent = __decorate([
    core_1.Component({
        selector: 'mac-list',
        templateUrl: './mac-list.component.html',
        styleUrls: ['./mac-list.component.css']
    }),
    __metadata("design:paramtypes", [router_1.Router, mac_service_1.MacService, http_1.HttpClient])
], MacListComponent);
exports.MacListComponent = MacListComponent;
//# sourceMappingURL=mac-list.component.js.map