import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { employee, usuario } from '../models/usuario';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {
  constructor(private http: HttpClient) {}
  VerifyEmployee(Employee: usuario): Observable<Boolean> {
    return this.http.get<boolean>('https://localhost:7090/api/Login/VerifyEmployee?UserName='+Employee.nombreUsuario+'&Password='+Employee.password);   
  }
  
  CreateEmployeed(Employee: employee): Observable<Boolean>{
    return this.http.get<boolean>('https://localhost:7090/api/Login/CreateEmployeed?Name='+Employee.name+'&Lastname='+Employee.lastName+'&UserName='+Employee.user+'&Password='+Employee.password)
  }



}


