import { Component, OnInit } from '@angular/core';
import { AbonoService } from 'src/app/services/abono.service';
import { ClienteService } from 'src/app/services/cliente.service';
import { Cliente } from '../models/cliente';

@Component({
  selector: 'app-cliente-consulta',
  templateUrl: './cliente-consulta.component.html',
  styleUrls: ['./cliente-consulta.component.css']
})
export class ClienteConsultaComponent implements OnInit {

  clientes: Cliente[];
  

  constructor(private serviceCliente:ClienteService, 
    private serviceAbonoService:AbonoService) { }

  ngOnInit() {
    this.getClientes();
  }

  getClientes() {
    this.clientes = this.serviceCliente.get();
  }

  getAbono(id: string) {
    return this.serviceAbonoService.calculoAbonos(id);
  }


}
