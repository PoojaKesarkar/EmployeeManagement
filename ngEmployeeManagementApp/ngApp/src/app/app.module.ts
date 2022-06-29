import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

import { EmpListComponent } from './Employee/EmployeeList/EmployeeList.component';
import { AddEmpComponent } from './Employee/AddEmployee/AddEmployee.component';
import { EmployeeService } from 'src/app/APIService/shared.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    EmpListComponent
        
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
      FormsModule,
      ReactiveFormsModule,
    RouterModule.forRoot([
        { path: '', component: EmpListComponent, pathMatch: 'full' },
        { path: 'addEmp', component: AddEmpComponent },
      //{ path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
    providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
