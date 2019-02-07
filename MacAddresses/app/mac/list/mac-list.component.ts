import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { MacService } from '../mac.service';
import { HttpClient } from '@angular/common/http';

import { MacAddress } from '../../data/model/macaddress';


@Component({
    selector: 'mac-list',
    templateUrl: './mac-list.component.html',
    styleUrls: ['./mac-list.component.css']
})
export class MacListComponent implements OnInit {
    title = 'Macs';
    macs: MacAddress[];

    constructor(private router: Router, private macService: MacService, private http: HttpClient) { }

    ngOnInit(): void {
        this.macs = this.macService.getMacs()
    }

    public sendMacsToServer() {
        const body = { Macs: this.macs };
        const req = this.http.post('/api/macapi/AddMacs', body);
        req.subscribe();
        this.macs.length = 0;
        this.macs = [];
    }
}
