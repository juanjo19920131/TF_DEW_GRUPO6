import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
  ///  private readonly us: UserService,
   /// private router: Router

  ) { }
  loginForm= this.fb.group({
      email:['', [Validators.required, Validators.email]],
      password:['',Validators.required]
   })
  

  Submit() {
    if(this.loginForm.valid) {
      console.log(this.loginForm.value);
    } else { 
      alert("Formulario no valido...");
    }

  }

  ngOnInit(): void {
  }

}
