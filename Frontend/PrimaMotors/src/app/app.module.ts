import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { InicioComponent } from './pages/inicio/inicio.component';
import { NosotrosComponent } from './pages/nosotros/nosotros.component';
import { ContactoComponent } from './pages/contacto/contacto.component';
import { AppRoutingModule } from './app-routing.module';
import { NissanComponent } from './pages/modelos/nissan/nissan.component';
import { ToyotaComponent } from './pages/modelos/toyota/toyota.component';
import { HyundaiComponent } from './pages/modelos/hyundai/hyundai.component';
import { SubaruComponent } from './pages/modelos/subaru/subaru.component';
import { BmwComponent } from './pages/modelos/bmw/bmw.component';
import { MercedesComponent } from './pages/modelos/mercedes/mercedes.component';
import { NuevoComponent } from './pages/servicios/nuevo/nuevo.component';
import { UsadoComponent } from './pages/servicios/usado/usado.component';
import { TallerComponent } from './pages/servicios/taller/taller.component';
import { CompranuevoNewComponent } from './access/compraventa/compranuevo-new/compranuevo-new.component';
import { CompranuevoListComponent } from './access/compraventa/compranuevo-list/compranuevo-list.component';
import { ComprausadoNewComponent } from './access/compraventa/comprausado-new/comprausado-new.component';
import { ComprausadoListComponent } from './access/compraventa/comprausado-list/comprausado-list.component';
import { VentausadoNewComponent } from './access/compraventa/ventausado-new/ventausado-new.component';
import { VentausadoListComponent } from './access/compraventa/ventausado-list/ventausado-list.component';
import { SolicitudNewComponent } from './access/taller/solicitud-new/solicitud-new.component';
import { SolicitudListComponent } from './access/taller/solicitud-list/solicitud-list.component';

@NgModule({
  declarations: [
    AppComponent,
    InicioComponent,
    NosotrosComponent,
    ContactoComponent,
    NissanComponent,
    ToyotaComponent,
    HyundaiComponent,
    SubaruComponent,
    BmwComponent,
    MercedesComponent,
    NuevoComponent,
    UsadoComponent,
    TallerComponent,
    CompranuevoNewComponent,
    CompranuevoListComponent,
    ComprausadoNewComponent,
    ComprausadoListComponent,
    VentausadoNewComponent,
    VentausadoListComponent,
    SolicitudNewComponent,
    SolicitudListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
