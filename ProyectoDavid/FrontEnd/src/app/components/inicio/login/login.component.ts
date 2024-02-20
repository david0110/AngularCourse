import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink } from '@angular/router';
import {usuario} from '../../../models/usuario';

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
  constructor(private fb: FormBuilder) {
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
  }

}
