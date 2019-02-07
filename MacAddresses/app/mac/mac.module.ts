import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { MacAddComponent } from './add/mac-add.component';
import { MacListComponent } from './list/mac-list.component';
import { MacValidator } from '../data/validators/macValidator';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule
    ],
    declarations: [
        MacAddComponent,
        MacListComponent,
        MacValidator
    ],
    providers: [],
    bootstrap: [MacAddComponent]
})
export class MacModule { }
