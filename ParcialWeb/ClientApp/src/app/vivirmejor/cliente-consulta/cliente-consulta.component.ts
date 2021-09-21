import { Component, OnInit } from '@angular/core';
import { AbonoService } from 'src/app/services/abono.service';
import { ClienteService } from 'src/app/services/cliente.service';
import { Abono } from '../models/abono';
import { Cliente } from '../models/cliente';

@Component({
  selector: 'app-cliente-consulta',
  templateUrl: './cliente-consulta.component.html',
  styleUrls: ['./cliente-consulta.component.css']
})
export class ClienteConsultaComponent implements OnInit {

  clientes: Cliente[];
  abonos: Abono[];
  

  constructor(private serviceCliente:ClienteService, 
    private serviceAbono:AbonoService) { }

  ngOnInit() {
    this.getClientes();
    this.getAbonos();
  }

  getClientes() {
    this.clientes = this.serviceCliente.get();
  }

  getAbonos() {
    this.abonos = this.serviceAbono.get();
  }

  getAbono(id: string) {
    return this.serviceAbono.calculoAbonos(id);
  }


}
