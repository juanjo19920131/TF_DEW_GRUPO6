import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NuevoService {

  constructor(
    private readonly http: HttpClient
  ) { }

  __getMarcas(){
    return this.http.get('https://localhost:44309/api/marca/listar');
  }

  __getModelos(param :string){
    return this.http.get('https://localhost:44309/api/modelo/listar' + param);
  }
}
