import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

//Custom
import { MacModule } from './mac/mac.module';
import { MacService } from './mac/mac.service';

import { AppComponent } from './app.component';
import { MacAddComponent } from './mac/add/mac-add.component';
import { MacListComponent } from './mac/list/mac-list.component';

const routes = [
    { path: 'mac/add', component: MacAddComponent },
    { path: 'mac/list', component: MacListComponent }
];

@NgModule({
  declarations: [
      AppComponent
  ],
  imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      HttpModule,
      RouterModule.forRoot(routes),
      MacModule
  ],
  providers: [MacService],
  bootstrap: [AppComponent]
})
export class AppModule { }
