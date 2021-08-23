import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'bytebank';
  destino: number = 0;
  valor : number = 0;

  transferir($event: any){
    this.destino = $event.destino;
    this.valor = $event.valor;
  }
}
