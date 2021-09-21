import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ClienteConsultaComponent } from './vivirmejor/cliente-consulta/cliente-consulta.component';
import { ClienteRegsitroComponent } from './vivirmejor/cliente-regsitro/cliente-regsitro.component';
import { AppRoutingModule } from './app-routing.module';
import { ClienteRegistrarAbonoComponent } from './vivirmejor/cliente-registrar-abono/cliente-registrar-abono.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ClienteConsultaComponent,
    ClienteRegsitroComponent,
    ClienteRegistrarAbonoComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
    ]),
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
