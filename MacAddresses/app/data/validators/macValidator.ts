import { Directive, forwardRef } from '@angular/core';
import { Validator, NG_VALIDATORS, AbstractControl } from '@angular/forms';

@Directive({
    selector: '[validateMac][formControlName],[validateMac][formControl],[validateMac][ngModel]',
    providers: [
        { provide: NG_VALIDATORS, useExisting: forwardRef(() => MacValidator), multi: true }
    ]
})
export class MacValidator implements Validator {
    validate(c: AbstractControl): { [key: string]: any } {
        let MAC_REGEXP = /^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$/i;
        return MAC_REGEXP.test(c.value) ? null : {
            validateMac: false
        };
    }
}
