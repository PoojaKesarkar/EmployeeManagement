var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { EmpListComponent } from './Employee/EmployeeList/EmployeeList.component';
import { EmployeeService } from 'src/app/APIService/shared.service';
let AppModule = class AppModule {
};
AppModule = __decorate([
    NgModule({
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
                //{ path: 'counter', component: CounterComponent },
                //{ path: 'fetch-data', component: FetchDataComponent },
            ])
        ],
        providers: [EmployeeService],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map