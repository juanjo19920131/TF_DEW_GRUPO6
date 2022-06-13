import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CompranuevoListComponent } from "./access/compraventa/compranuevo-list/compranuevo-list.component";
import { CompranuevoNewComponent } from "./access/compraventa/compranuevo-new/compranuevo-new.component";
import { ComprausadoListComponent } from "./access/compraventa/comprausado-list/comprausado-list.component";
import { ComprausadoNewComponent } from "./access/compraventa/comprausado-new/comprausado-new.component";
import { VentausadoListComponent } from "./access/compraventa/ventausado-list/ventausado-list.component";
import { VentausadoNewComponent } from "./access/compraventa/ventausado-new/ventausado-new.component";
import { SolicitudListComponent } from "./access/taller/solicitud-list/solicitud-list.component";
import { SolicitudNewComponent } from "./access/taller/solicitud-new/solicitud-new.component";
import { ContactoComponent } from "./pages/contacto/contacto.component";
import { InicioComponent } from "./pages/inicio/inicio.component";
import { BmwComponent } from "./pages/modelos/bmw/bmw.component";
import { HyundaiComponent } from "./pages/modelos/hyundai/hyundai.component";
import { MercedesComponent } from "./pages/modelos/mercedes/mercedes.component";
import { NissanComponent } from "./pages/modelos/nissan/nissan.component";
import { SubaruComponent } from "./pages/modelos/subaru/subaru.component";
import { ToyotaComponent } from "./pages/modelos/toyota/toyota.component";
import { NosotrosComponent } from "./pages/nosotros/nosotros.component";
import { NuevoComponent } from "./pages/servicios/nuevo/nuevo.component";
import { TallerComponent } from "./pages/servicios/taller/taller.component";
import { UsadoComponent } from "./pages/servicios/usado/usado.component";

const routes: Routes = [
    { path: 'inicio', component: InicioComponent},
    { path: 'nosotros', component: NosotrosComponent},
    { path: 'modelos/nissan', component: NissanComponent},
    { path: 'modelos/toyota', component: ToyotaComponent},
    { path: 'modelos/hyundai', component: HyundaiComponent},
    { path: 'modelos/subaru', component: SubaruComponent},
    { path: 'modelos/bmw', component: BmwComponent},
    { path: 'modelos/mercedes', component: MercedesComponent},
    { path: 'servicios/nuevo', component: NuevoComponent},
    { path: 'servicios/usado', component: UsadoComponent},
    { path: 'servicios/taller', component: TallerComponent},
    { path: 'admin/nuevo/compra/new', component: CompranuevoNewComponent},
    { path: 'admin/nuevo/compra/list', component: CompranuevoListComponent},
    { path: 'admin/usado/compra/new', component: ComprausadoNewComponent},
    { path: 'admin/usado/compra/list', component: ComprausadoListComponent},
    { path: 'admin/usado/venta/new', component: VentausadoNewComponent},
    { path: 'admin/usado/venta/list', component: VentausadoListComponent},
    { path: 'admin/taller/solicitud/new', component: SolicitudNewComponent},
    { path: 'admin/taller/solicitud/list', component: SolicitudListComponent},
    { path: 'contacto', component: ContactoComponent},
    { path: '', redirectTo: 'inicio', pathMatch: 'full'}
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}