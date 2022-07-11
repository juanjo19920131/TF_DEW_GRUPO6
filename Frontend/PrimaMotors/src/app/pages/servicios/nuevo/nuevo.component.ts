import { Component, OnInit } from '@angular/core';
import { NuevoService } from 'src/app/services/nuevo.service';

@Component({
  selector: 'app-nuevo',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoComponent implements OnInit {

  constructor(
    private readonly ns: NuevoService
  ) { }

  marcas: any = [];

  __listarMarcas(){
    this.ns.__getMarcas().subscribe((rest: any) => {
      this.marcas = rest.data;
      console.log(this.marcas)
    })
  }

  ngOnInit(): void {
    this.__listarMarcas();
  }

}
