import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class EmployeeService {
    readonly APIUrl = "http://localhost:52109/api";

    constructor(private http: HttpClient) { }

    getEmpList(): Observable<any[]> {
        return this.http.get<any>(this.APIUrl + '/Employee');
    }
}