import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { MacService } from '../mac.service';
import { MacAddress } from '../../data/model/macaddress';
import { MacValidator } from "../../data/validators/macValidator";

@Component({
    selector: 'mac-add',
    templateUrl: './mac-add.component.html',
    styleUrls: ['./mac-add.component.css']
})
export class MacAddComponent {
    title = 'Add mac';
    mac = new MacAddress('');

    constructor(private router: Router, private macService: MacService) { }

    public addMac(): void {
        if (!this.macService.isExist(this.mac)) {
            this.macService.addMac(new MacAddress(this.mac.value));
            this.mac.value = '';
        } else {
            alert('Already exist');
        }
    }
}
