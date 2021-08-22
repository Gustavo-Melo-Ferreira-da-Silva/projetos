import { Component } from '@angular/core';

@Component({
  selector: 'app-nova-tranferencia',
  templateUrl: './nova-tranferencia.component.html',
  styleUrls: ['./nova-tranferencia.component.scss'],
})
export class NovaTranferenciaComponent {
  valor :number = 0;
  destino: number = 0;

  transferir() {
    console.log('Solicitada nova tranferência');
    console.log('Valor: ', this.valor);
    console.log('Destino', this.destino);
  }
}
