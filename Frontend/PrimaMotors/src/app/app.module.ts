import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { InicioComponent } from './pages/inicio/inicio.component';
import { NosotrosComponent } from './pages/nosotros/nosotros.component';
import { ContactoComponent } from './pages/contacto/contacto.component';
import { AppRoutingModule } from './app-routing.module';
import { NuevoComponent } from './pages/servicios/nuevo/nuevo.component';
import { UsadoComponent } from './pages/servicios/usado/usado.component';
import { TallerComponent } from './pages/servicios/taller/taller.component';
import { LoginComponent } from './pages/login/login.component';
import { MarcasComponent } from './pages/marcas/marcas.component';
import { CotizarnuevoComponent } from './pages/cotizarnuevo/cotizarnuevo.component';
import { CotizarusadoComponent } from './pages/cotizarusado/cotizarusado.component';
import { SolicitudtallerComponent } from './pages/solicitudtaller/solicitudtaller.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RetrieveComponent } from './pages/retrieve/retrieve.component';
import { UsernewComponent } from './pages/usernew/usernew.component';

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
    LoginComponent,
    CotizarnuevoComponent,
    CotizarusadoComponent,
    SolicitudtallerComponent,
    RetrieveComponent,
    UsernewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
