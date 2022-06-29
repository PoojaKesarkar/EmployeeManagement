import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/APIService/shared.service';

@Component({
    selector: 'emp-List',
    templateUrl: './EmployeeList.component.html',
    styleUrls: ['./EmployeeList.component.css']
})
export class EmpListComponent implements OnInit {

    constructor(private service: EmployeeService) { }

    EmployeeList: any = [];

    ngOnInit(): void {
        this.refreshEmpList();
    }

    refreshEmpList() {
        this.service.getEmpList().subscribe(data => {
            this.EmployeeList = data;
        });
    }
}