import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ContactoComponent } from "./pages/contacto/contacto.component";
import { InicioComponent } from "./pages/inicio/inicio.component";
import { LoginComponent } from "./pages/login/login.component";
import { NosotrosComponent } from "./pages/nosotros/nosotros.component";
import { NuevoComponent } from "./pages/servicios/nuevo/nuevo.component";
import { TallerComponent } from "./pages/servicios/taller/taller.component";
import { UsadoComponent } from "./pages/servicios/usado/usado.component";
import { MarcasComponent } from "./pages/marcas/marcas.component";

const routes: Routes = [
    { path: 'inicio', component: InicioComponent},
    { path: 'nosotros', component: NosotrosComponent},
    { path: 'servicios/nuevo', component: NuevoComponent},
    { path: 'servicios/usado', component: UsadoComponent},
    { path: 'servicios/taller', component: TallerComponent},
    { path: 'contacto', component: ContactoComponent},
    { path: 'Login', component: LoginComponent},
    { path: '', redirectTo: 'inicio', pathMatch: 'full'},
    { path: 'marcas', component: MarcasComponent}
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}