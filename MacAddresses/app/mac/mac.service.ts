import { Injectable } from '@angular/core';
import { MacAddress } from '../data/model/macaddress';

@Injectable()
export class MacService {
    private macs: MacAddress[] = []

    public getMacs(): MacAddress[] {
        return this.macs;
    }

    public addMac(m: MacAddress): void {
        this.macs.push(m);
    }

    public isExist(m: MacAddress): boolean {
        var vals = this.macs.map(function (v) {
            return v.value;
        });
        return vals.includes(m.value);
    }
}
