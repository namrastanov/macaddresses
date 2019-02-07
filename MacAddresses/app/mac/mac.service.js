"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var MacService = (function () {
    function MacService() {
        this.macs = [];
    }
    MacService.prototype.getMacs = function () {
        return this.macs;
    };
    MacService.prototype.addMac = function (m) {
        this.macs.push(m);
    };
    MacService.prototype.isExist = function (m) {
        var vals = this.macs.map(function (v) {
            return v.value;
        });
        return vals.includes(m.value);
    };
    return MacService;
}());
MacService = __decorate([
    core_1.Injectable()
], MacService);
exports.MacService = MacService;
//# sourceMappingURL=mac.service.js.map