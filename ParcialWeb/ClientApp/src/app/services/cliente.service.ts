import { Injectable } from '@angular/core';
import { Cliente } from '../vivirmejor/models/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  
  constructor() { }

  get(): Cliente[]{
    return JSON.parse(localStorage.getItem('datosCliente'));
  }

  post(cliente: Cliente){
    let clientes: Cliente[] = [];
    if(this.get() != null){
      clientes = this.get();
    }

    clientes.push(cliente);
    localStorage.setItem('datosCliente', JSON.stringify(clientes));
  }

  validateExistente(identificacion: string) {
    let clientes: Cliente[];
    clientes = this.get();
    if(clientes != null){
      for(var item of clientes){
        if(identificacion === item.identificacion){
          return item;
        }
      }
    }
    return null;
  }
}

