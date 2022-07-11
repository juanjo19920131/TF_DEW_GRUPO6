import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NuevoService } from 'src/app/services/nuevo.service';

@Component({
  selector: 'app-nuevo',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    private readonly ns: NuevoService
  ) { }

  marcas: any = [];

  servicioNuevoForm = this.fb.group({
    marca: ['', Validators.required]/*,
    modelos: this.fb.group({
      nombre: ['', Validators.required],
      apellido: ['', Validators.required]
    })*/
  })

  __listarMarcas(){
    this.ns.__getMarcas().subscribe((rest: any) => {
      this.marcas = rest.data;
      //console.log(this.marcas)
    })
  }

  __listarModelos(item: any){
    //this.ns.__getModelos(item.value).subscribe((rest: any) => {
      //this.modelos = rest.data;
      console.log("")
    //})
  }

  ngOnInit(): void {
    this.__listarMarcas();
  }

  onChange(value: any) {
    console.log(value)
    //this.__listarModelos(this.servicioNuevoForm.value)
  }

}
