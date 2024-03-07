import { Component } from '@angular/core';
import { NavbarComponent } from "./navbar/navbar.component";
import { RouterOutlet } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
    selector: 'app-dashboard',
    standalone: true,
    templateUrl: './dashboard.component.html',
    styleUrl: './dashboard.component.css',
    imports: [NavbarComponent, RouterOutlet, ReactiveFormsModule, CommonModule]
})
export class DashboardComponent {

}
