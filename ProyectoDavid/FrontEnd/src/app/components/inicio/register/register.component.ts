import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {AbstractControlOptions, FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { LoginServiceService } from '../../../services/login-service.service';
import { employee } from '../../../models/usuario';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [RouterLink, CommonModule, ReactiveFormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  registerForm: FormGroup;
  isLoading: boolean = false;


  constructor(private fb: FormBuilder, private toastr: ToastrService, private router: Router,private LoginService: LoginServiceService) {
    this.registerForm = fb.group({
      name: ['',Validators.required],
      lastName: ['',Validators.required],
      usuario: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(4)]],
      repPassword:['']
    }, {validator: this.checkPassword});
  }


  registrarUsusario(): void{
    console.log(this.registerForm);
    const Employee: employee ={
      name: this.registerForm.value.name,
      lastName: this.registerForm.value.lastName,
      user: this.registerForm.value.usuario,
      password:this.registerForm.value.password
    }
    this.LoginService.CreateEmployeed(Employee).subscribe(result =>{
      if(result == true){
        this.router.navigate(['inicio'])
        this.toastr.success("Has creado el empleado correctamente","Felicidades")
      }else{
        this.toastr.error("No pudiste crear tu usuario correctamente","ERROR");
      }
    })

  }

  checkPassword(group: FormGroup): any {
    const pass = group.controls['password'].value; 
    const repPassword = group.controls['repPassword'].value;
    return pass === repPassword ? null : {notSame: true}
  }
}


