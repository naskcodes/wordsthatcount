import { Component, OnInit } from '@angular/core';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AppService } from '../app-service';

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
  dados: any = null;

  constructor(private srv: AppService) { }

  ngOnInit(): void {
    this.retornaRegistros();
    console.log(this.dados)
  }

  retornaRegistros() {
    console.log("Testando");
    this.srv.Registros().subscribe({
      next: (p) => {
        this.dados = p;
        console.log(this.dados);
      }
    })
  }

  adicionaPalavras() {
    console.log("clicou");
  }
}
