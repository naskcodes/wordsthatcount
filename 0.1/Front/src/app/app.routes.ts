import { Routes } from '@angular/router';
import { NovoRegistro } from './novo-registro/novo-registro';
import { Entrada } from './entrada/entrada';

export const routes: Routes = [
    { path: '', redirectTo: '/entrada', pathMatch: 'full' },
    { path: 'novoregistro', component: NovoRegistro },
    { path: 'entrada', component: Entrada },
];
