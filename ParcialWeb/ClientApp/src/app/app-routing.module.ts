import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ClienteRegsitroComponent } from './vivirmejor/cliente-regsitro/cliente-regsitro.component';
import { ClienteRegistrarAbonoComponent } from './vivirmejor/cliente-registrar-abono/cliente-registrar-abono.component';

const routes: Routes = [
  { path: 'registrar', component: ClienteRegsitroComponent},
  {path: 'abonar', component: ClienteRegistrarAbonoComponent}
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]

})
export class AppRoutingModule { }
