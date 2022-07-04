import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

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
    persona: this.fb.group({
      nombre:['',Validators.required],
    apellido:['',Validators.required]
    }),
    email:['', [Validators.required, Validators.email]],
    mensaje:['',Validators.required]
  })

  __onSubmit() {
    if(this.ContactoForm.valid) {
      console.log(this.ContactoForm.value);
    } else { 
      alert("Formulario no valido...");
    }

  }


  ngOnInit(): void {
  }

}
