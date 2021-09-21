import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ClienteRegsitroComponent } from './vivirmejor/cliente-regsitro/cliente-regsitro.component';

const routes: Routes = [
  { path: 'registrar', component: ClienteRegsitroComponent},
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
