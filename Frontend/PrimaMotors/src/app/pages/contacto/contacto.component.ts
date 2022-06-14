import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-contacto',
  templateUrl: './contacto.component.html',
  styleUrls: ['./contacto.component.css']
})
export class ContactoComponent implements OnInit {

  constructor(
    private fb: FormBuilder
  ) { }

  ContactoForm= this.fb.group({
    nombre:[''],
    apellido:[''],
    email:[''],
    mensaje:['']
  })

  ___onSubmit(){
    if (this.ContactoForm.valid){
      console.log(this.ContactoForm.value);
   } else {
    alert ("formulario no valido");
   }

  }


  ngOnInit(): void {
  }

}
