import { Injectable } from '@angular/core';
import { Cliente } from '../vivirmejor/models/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  clientes: Cliente[];
  constructor() { }

  get(): Cliente[]{
    return JSON.parse(localStorage.getItem('datos'));
  }

  post(cliente: Cliente){
    let clientes: Cliente[] = [];
    if(this.get() != null){
      clientes = this.get();
    }

    clientes.push(cliente);
    localStorage.setItem('datos', JSON.stringify(clientes));
  }

  validateExistente(cliente: Cliente){
    this.clientes = this.get();
    if(this.clientes != null){
      for(var item of this.clientes){
        if(cliente.identificacion === item.identificacion){
          return true;
        }
      }
    }
    return false;
  }
}

