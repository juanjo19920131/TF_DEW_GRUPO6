import { Component, OnInit } from '@angular/core';
import { MarcaService } from 'src/app/services/marca.service';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css']
})
export class InicioComponent implements OnInit {

  constructor(
    private readonly ms: MarcaService
  ) { }

  marcas: any = [];

  __obtenerMarcas(){
    this.ms.__getMarcas().subscribe((rest: any) => {
      console.log(rest)
    })
  }

  ngOnInit(): void {
    this.__obtenerMarcas();
  }

}
