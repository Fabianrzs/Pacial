import { Component, OnInit } from '@angular/core';
import { ClienteService } from 'src/app/services/cliente.service';
import { Cliente } from '../models/cliente';

@Component({
  selector: 'app-cliente-regsitro',
  templateUrl: './cliente-regsitro.component.html',
  styleUrls: ['./cliente-regsitro.component.css']
})

export class ClienteRegsitroComponent implements OnInit {

  cliente: Cliente;

  constructor(private clienteService: ClienteService) { }

  ngOnInit() {
    this.cliente = new Cliente;
  }

  calcularCuota(){
    
    this.cliente.calcularValor();

    if (this.clienteService.validateExistente(this.cliente.identificacion) == null){      
      this.clienteService.post(this.cliente);
      alert('seguardo'+ JSON.stringify(this.cliente));
    }else{
       alert('Ya se encontro registrado en el programa');
    }
  }

}
