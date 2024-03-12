import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import {usuario} from '../../../models/usuario';
import { LoginServiceService } from '../../../services/login-service.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [RouterLink, CommonModule, ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  login: FormGroup;
  isLoading: boolean = false;


  constructor(private fb: FormBuilder,private toastr: ToastrService,private router: Router, private LoginService: LoginServiceService ) {
    this.login = this.fb.group({
      usuario: ['', Validators.required],
      password: ['', Validators.required]
    })
  }

  log(): void {
    console.log(this.login);

    const usuario: usuario = {
      nombreUsuario: this.login.value.usuario,
      password: this.login.value.password
    }
    console.log(usuario);
    this.LoginService.VerifyEmployee(usuario).subscribe(result =>{
      if (result == true){
        this.router.navigate(['dashboard']);
        this.toastr.success("Te has logeado exitosamente","Bienvenid@")
      }else{
        this.toastr.error("Usuario o contraseña incorrectos","ERROR");
        this.login.reset();
      }
    })
  }

}
