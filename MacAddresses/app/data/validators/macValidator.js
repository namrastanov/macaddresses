"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var MacValidator = MacValidator_1 = (function () {
    function MacValidator() {
    }
    MacValidator.prototype.validate = function (c) {
        var MAC_REGEXP = /^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$/i;
        return MAC_REGEXP.test(c.value) ? null : {
            validateMac: false
        };
    };
    return MacValidator;
}());
MacValidator = MacValidator_1 = __decorate([
    core_1.Directive({
        selector: '[validateMac][formControlName],[validateMac][formControl],[validateMac][ngModel]',
        providers: [
            { provide: forms_1.NG_VALIDATORS, useExisting: core_1.forwardRef(function () { return MacValidator_1; }), multi: true }
        ]
    })
], MacValidator);
exports.MacValidator = MacValidator;
var MacValidator_1;
//# sourceMappingURL=macValidator.js.map