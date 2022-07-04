import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-retrieve',
  templateUrl: './retrieve.component.html',
  styleUrls: ['./retrieve.component.css']
})
export class RetrieveComponent implements OnInit {

  constructor(
    private fb: FormBuilder
  ) { }

  retrieveForm= this.fb.group({
    email:['', [Validators.required, Validators.email]],
    
  })

  Submit() {
    if(this.retrieveForm.valid) {
      console.log(this.retrieveForm.value);
      alert("Se a enviado un mensaje a su correo...");
    } else { 
      alert("Por favor revise su correo...");
    }

  }

  ngOnInit(): void {
  }

};

