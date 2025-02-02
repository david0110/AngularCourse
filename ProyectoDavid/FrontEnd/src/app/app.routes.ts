import { Routes } from '@angular/router';
import { BienvenidaComponent } from './components/inicio/bienvenida/bienvenida.component';
import { RegisterComponent } from './components/inicio/register/register.component';
import { LoginComponent } from './components/inicio/login/login.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { CuestionariosComponent } from './components/dashboard/cuestionarios/cuestionarios.component';
import { CambiarPasswordComponent } from './components/dashboard/cambiar-password/cambiar-password.component';

export const routes: Routes = [
    {path: '' , redirectTo: '/inicio', pathMatch:'full'},
    {path: 'inicio', component: InicioComponent, children:[
        {path: '' , component: BienvenidaComponent},
        {path: 'register' , component: RegisterComponent},
        {path: 'login' , component: LoginComponent},
    ]},
    {path: 'dashboard', component: DashboardComponent, children:[
        {path: '', component: CuestionariosComponent},
        {path: 'cambiarPassword', component: CambiarPasswordComponent}
    ]},
    {path: '**' , redirectTo: '/inicio', pathMatch:'full'}
];
