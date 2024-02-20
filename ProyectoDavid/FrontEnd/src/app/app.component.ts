import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { InicioComponent } from './components/inicio/inicio.component';
import {ReactiveFormsModule} from '@angular/forms';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, InicioComponent,ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  listEstudiantes: any[] = [
    {nombre: 'David', estado: 'Promocionado'},
    {nombre: 'Salome', estado: 'Promocionado'},
    {nombre: 'Pedro', estado: 'Promocionado'},
    {nombre: 'Carlos', estado: 'Regular'},
    {nombre: 'Andres', estado: 'Regular'},
    {nombre: 'Sandra', estado: 'Regular'},
    {nombre: 'Ana', estado: 'Regular'}
  ]
  mostrar = true;
  Hide(): void {
    this.mostrar = !this.mostrar; 
  }
}



