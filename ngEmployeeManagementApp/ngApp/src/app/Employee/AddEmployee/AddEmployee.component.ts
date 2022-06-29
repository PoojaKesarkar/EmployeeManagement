import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/APIService/shared.service';

@Component({
    selector: 'emp-Add',
    templateUrl: './AddEmployee.component.html',
    styleUrls: ['./AddEmployee.component.css']
})
export class AddEmpComponent implements OnInit {

    constructor(private service: EmployeeService) { }

    ngOnInit(): void {
    }

}