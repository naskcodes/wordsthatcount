import { Component } from '@angular/core';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';

@Component({
  selector: 'app-entrada',
  imports: [InputTextModule, ButtonModule],
  templateUrl: './entrada.html',
  styleUrl: './entrada.scss'
})
export class Entrada {

}
