import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ContactoComponent } from "./pages/contacto/contacto.component";
import { InicioComponent } from "./pages/inicio/inicio.component";
import { ModelosComponent } from "./pages/modelos/modelos.component";
import { NosotrosComponent } from "./pages/nosotros/nosotros.component";
import { ServiciosComponent } from "./pages/servicios/servicios.component";

const routes: Routes = [
    { path: 'inicio', component: InicioComponent},
    { path: 'nosotros', component: NosotrosComponent},
    { path: 'modelos', component: ModelosComponent},
    { path: 'servicios', component: ServiciosComponent},
    { path: 'contacto', component: ContactoComponent}
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}