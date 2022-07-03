import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { InicioComponent } from './pages/inicio/inicio.component';
import { NosotrosComponent } from './pages/nosotros/nosotros.component';
import { ContactoComponent } from './pages/contacto/contacto.component';
import { AppRoutingModule } from './app-routing.module';
import { NuevoComponent } from './pages/servicios/nuevo/nuevo.component';
import { UsadoComponent } from './pages/servicios/usado/usado.component';
import { TallerComponent } from './pages/servicios/taller/taller.component';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './pages/login/login.component';
import { MarcasComponent } from './pages/marcas/marcas.component';

@NgModule({
  declarations: [
    AppComponent,
    InicioComponent,
    NosotrosComponent,
    ContactoComponent,
    NuevoComponent,
    UsadoComponent,
    TallerComponent,
    MarcasComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
