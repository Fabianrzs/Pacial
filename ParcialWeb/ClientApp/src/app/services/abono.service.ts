import { Injectable } from '@angular/core';
import { Abono } from '../vivirmejor/models/abono';

@Injectable({
  providedIn: 'root'
})
export class AbonoService {

  constructor() { }

  get(): Abono[]{
    return JSON.parse(localStorage.getItem('datosAbono'));
  }

  post(abono: Abono){
    let abonos: Abono[] = [];
    if(this.get() != null){
      abonos = this.get();
    }

    abonos.push(abono);
    localStorage.setItem('datosAbono', JSON.stringify(abonos));
  }

  calculoAbonos(idabonos: string) {
    var total = 0;
    let abonos: Abono[];
    abonos = this.get();
    if(abonos != null){
      for(var item of abonos){
        if(idabonos === item.idCLiente){
           total = total + item.valorAbono;
        }
      }
    }
    
    return total;
  }


}
