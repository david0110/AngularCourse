import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {AbstractControlOptions, FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

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
  constructor(private fb: FormBuilder, private toastr: ToastrService, private router: Router) {
    this.registerForm = fb.group({
      usuario: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(4)]],
      repPassword:['']
    }, {validator: this.checkPassword});
  }


  registrarUsusario(): void{
    console.log(this.registerForm);
  }

  checkPassword(group: FormGroup): any {
    const pass = group.controls['password'].value; 
    const repPassword = group.controls['repPassword'].value;
    return pass === repPassword ? null : {notSame: true}
  }
}


