import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-nova-tranferencia',
  templateUrl: './nova-tranferencia.component.html',
  styleUrls: ['./nova-tranferencia.component.scss'],
})
export class NovaTranferenciaComponent {

  @Output() aoTransferir = new EventEmitter<any>();

  valor :number = 0;
  destino: number = 0;

  transferir() {
    const valorEmitir = {valor: this.valor, destino: this.destino};
    this.aoTransferir.emit(valorEmitir);

  }
}
