export class Cliente {

    identificacion: string;
    nombre: string;
    proyecto : string;
    valor : number;
    cuotaInicial : number;

    calcularValor(){
        switch (this.proyecto){
            case 'BM':
                this.valor = 40000.00;
                this.cuotaInicial = this.valor * 0.2;
            break;   
            case 'BC':
                this.valor = 50000.00;
                this.cuotaInicial = this.valor * 0.2
            break; 
            case 'JR':
                this.valor = 70000.00;
                this.cuotaInicial = this.valor * 0.2
            break; 
        }
    }

}
