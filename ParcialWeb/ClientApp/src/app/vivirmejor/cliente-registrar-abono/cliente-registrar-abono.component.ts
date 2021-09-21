import { Component, OnInit } from '@angular/core';
import { AbonoService } from 'src/app/services/abono.service';
import { ClienteService } from 'src/app/services/cliente.service';
import { Abono } from '../models/abono';

@Component({
  selector: 'app-cliente-registrar-abono',
  templateUrl: './cliente-registrar-abono.component.html',
  styles: []
})
export class ClienteRegistrarAbonoComponent implements OnInit {

  abono: Abono;

  constructor(private clienteService: ClienteService, 
    private abonoService: AbonoService) { }

  ngOnInit() {
    this.abono = new Abono();
  }

  guardarAbono() {
    let cliente = this.clienteService.validateExistente(this.abono.idCLiente);

    if(cliente != null){   
      var sumAbonos = this.abonoService.calculoAbonos(this.abono.idCLiente)    
      if(sumAbonos >= cliente.cuotaInicial){        
        alert("El cliente ya finalizo el pago del abono");       
      }
      this.abonoService.post(this.abono);
      alert('se registro el abono por '+(this.abono.valorAbono));      
    }else{
      alert("el cliente con la identificacion no esta registrado")
    }

  }

}
