import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';

@Component({
  selector: 'app-novo-registro',
  imports: [InputTextModule, ButtonModule],
  templateUrl: './novo-registro.html',
  styleUrl: './novo-registro.scss'
})
export class NovoRegistro {
  formularioRegistroPalavras = new FormGroup({
    id: new FormControl<any>(null),
    usuario: new FormControl<any>(null, [Validators.required]),
    palavras: new FormControl<any>(null, [Validators.required]),
    dataRegistro: new FormControl<any>(null)
  });

  adicionaPalavras() {
    
  }
}
